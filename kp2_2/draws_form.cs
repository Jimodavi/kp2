using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp2_2
{
    public partial class draws_form : Form
    {
        private int code_tournament;
        private int number_of_participants;
        private int number_of_courts;
        private int[] codes_courts;
        private DateTime date_begining;
        private DateTime date_end;
        private DateTime time_begining;
        private DateTime time_end;
        private int duration;
        private bool out_of_time = false;
        public draws_form(int code_tournament, int number_of_participants, int number_of_courts, int[] codes_courts, DateTime date_begining, DateTime date_end, int duration, DateTime time_begining, DateTime time_end)
        {
            InitializeComponent();
            this.code_tournament = code_tournament;
            this.number_of_participants = number_of_participants;
            this.number_of_courts = number_of_courts;
            this.codes_courts = codes_courts;
            this.date_begining = date_begining;
            this.date_end = date_end;
            this.time_begining = time_begining;
            this.time_end = time_end;
            this.duration = duration;
        }
        private void generate ()
        {
            System.Data.OleDb.OleDbCommand Command;
            Command = new global::System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbConnection Connection;
            Connection = new global::System.Data.OleDb.OleDbConnection();
            Connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
            Connection.Open();
            Command.Connection = Connection;            
            
            /*перенести коды участников в массив*/
            Command.CommandText = "SELECT * FROM [Списки участников] WHERE [Код турнира] = " + code_tournament.ToString() + " ORDER BY [Код учаcтника]";
            System.Data.OleDb.OleDbDataReader Reader = Command.ExecuteReader();
            int[] codes_partisipants = new int[number_of_participants];
            int i = 0;
            while (Reader.Read())
            {
                codes_partisipants[i] = (int)Reader[0];
                i++;
            }
            Reader.Close();
            Connection.Close();

            /*заполнение [Сетки]*/
            int count = 0;
            int place = 0;
            for (i = 0; i < number_of_participants; i++)
                for (int j = i + 1; j < number_of_participants; j++)
                {
                    string newelement = кп2_DataSet.Next_DB_index("Код матча", "Сетки").ToString();
                    newelement += ", " + code_tournament.ToString();
                    newelement += ", " + codes_partisipants[i].ToString();
                    newelement += ", " + codes_partisipants[j].ToString();
                    newelement += ", '', '', '', null, null";
                    newelement += ", " + place.ToString();
                    count++;
                    Сетки_TableAdapter.Insert(newelement);
                }

            /*установка даты и времени начала и конца*/
            date_begining = date_begining.AddHours(-date_begining.Hour + time_begining.Hour);
            date_begining = date_begining.AddMinutes(-date_begining.Minute + time_begining.Minute);
            date_end = date_end.AddHours(-date_end.Hour + time_end.Hour);
            date_end = date_end.AddMinutes(-date_end.Minute + time_end.Minute);

            /*перенести [Код матча], [Код участника 1], [Код участника 2] из [Сетки] в массив*/
            Connection.Open();
            Command.CommandText = "SELECT * FROM [Сетки] WHERE [Код турнира] = " + code_tournament.ToString() + " ORDER BY [Код матча]";
            Reader = Command.ExecuteReader();
            int[,] draws = new int[count, 4];
            int[] time_slot = new int[3];
            i = 0;
            while (Reader.Read())
            {
                draws[i, 0] = (int)Reader[0];
                draws[i, 1] = (int)Reader[2];
                draws[i, 2] = (int)Reader[3];
                draws[i, 3] = 0;/*поле для обозначения матчей, для которых есть время в расписании*/
                i++;
            }
            Reader.Close();
            Connection.Close();

            /*заполнение [Расписания]*/
            bool finished = false;
            bool repeat;
            int skip;
            int skipped;
            for (; !finished;)
            {
                skip = 0;
                place++;
                for (int current_court = 0; current_court < number_of_courts; current_court++)
                {
                    skipped = 0;
                    finished = true;
                    for (i = 0; i < count; i++)
                        if (draws[i, 3] == 0)
                        {
                            finished = false;
                            if (skip == skipped) break;
                            else skipped++;
                        }
                    if (i == count) break;
                    string newelement = draws[i, 0].ToString();
                    newelement += ", " + code_tournament.ToString();
                    time_slot[current_court] = i;
                    repeat = false;
                    for (int j = 0; (!repeat) && (j < current_court); j++)
                    {
                        if ((draws[time_slot[j],1] == draws[i, 1])
                           ||
                           (draws[time_slot[j], 2] == draws[i, 1])
                           ||
                           (draws[time_slot[j], 1] == draws[i, 2])
                           ||
                           (draws[time_slot[j], 2] == draws[i, 2]))
                        {
                            repeat = true;
                        }
                    }
                    if (repeat)
                    {
                        repeat = false;
                        skip++;
                        current_court--;
                    }
                    else
                    {
                        draws[i, 3] = 1;
                        Сетки_TableAdapter.Update("[Место] = " + place.ToString(), draws[i, 0].ToString());
                        newelement += ", " + codes_courts[current_court];
                        newelement += ", '" + date_begining.ToString() + "'";
                        Расписание_TableAdapter.Insert(newelement);
                    }
                }
                if (finished) break;
                if (!out_of_time && (date_begining >= date_end.AddMinutes(-duration))) out_of_time = true;
                time_end = time_end.AddYears(-time_end.Year + date_begining.Year);
                time_end = time_end.AddMonths(-time_end.Month + date_begining.Month);
                time_end = time_end.AddDays(-time_end.Day + date_begining.Day);
                if (date_begining.AddMinutes(duration + 10) > time_end)
                {
                    date_begining = date_begining.AddDays(1);
                    date_begining = date_begining.AddHours(-date_begining.Hour + time_begining.Hour);
                    date_begining = date_begining.AddMinutes(-date_begining.Minute + time_begining.Minute);
                }
                else
                {
                    date_begining = date_begining.AddMinutes(duration + 10);
                }
            }
            if (out_of_time) MessageBox.Show("На матчи не хватило заданого промежутка времени", "Ошибка");
        }
        private void draws_form_Load(object sender, EventArgs e)
        {
            this.Сетки_TableAdapter.Fill(кп2_DataSet.Сетки, code_tournament.ToString());
            this.Расписание_TableAdapter.Fill(кп2_DataSet.Расписание, code_tournament.ToString());
            System.Data.OleDb.OleDbCommand Command;
            Command = new global::System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbConnection Connection;
            Connection = new global::System.Data.OleDb.OleDbConnection();
            Command.Connection = Connection;
            Connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
            Connection.Open();

            Command.CommandText = "SELECT top 1 [Код матча] FROM [Сетки] where [Код турнира] = " + code_tournament.ToString();
            int flag = Command.ExecuteScalar() == System.DBNull.Value ? 0 : (int)Command.ExecuteScalar();
            if(flag == 0) {
                generate();
            }

            Command.CommandText = "SELECT * FROM [Списки участников] WHERE [Код турнира] = " + code_tournament.ToString() + " ORDER BY [Код учаcтника]";
            System.Data.OleDb.OleDbDataReader Reader = Command.ExecuteReader();
            int[] codes_partisipants = new int[number_of_participants];
            int i = 0;
            while (Reader.Read())
            {
                codes_partisipants[i] = (int)Reader[0];
                i++;
            }
            Reader.Close();
            Command.CommandText = "SELECT count (*) FROM [Сетки] WHERE [Код турнира] = " + code_tournament.ToString() ;
            flag = (int)Command.ExecuteScalar();
            Command.CommandText = "SELECT [Счёт первого сета], [Счёт второго сета], [Счёт третьего сета] FROM [Сетки] WHERE [Код турнира] = " + code_tournament.ToString() + " ORDER BY [Код матча]";
            Reader = Command.ExecuteReader();
            string[,] draws = new string[flag, 3];
            i = 0;
            while (Reader.Read())
            {
                draws[i, 0] = (Reader[0] == System.DBNull.Value ? "" : (string)Reader[0]);
                draws[i, 1] = (Reader[1] == System.DBNull.Value ? "" : (string)Reader[1]);
                draws[i, 2] = (Reader[2] == System.DBNull.Value ? "" : (string)Reader[2]);
                i++;
            }
            Reader.Close();
            Connection.Close();


            /*заполнение DataGridView*/
            Сетки_DataGridView.ColumnCount = number_of_participants + 1;
            Сетки_DataGridView.RowCount = number_of_participants + 1;
            for (int k = 0; k < Сетки_DataGridView.ColumnCount; k++)
                Сетки_DataGridView.Rows[k].Cells[k].Style.BackColor = System.Drawing.Color.Gray;
            for (i = 1; i < Сетки_DataGridView.ColumnCount; i++)
            {
                string code_participant = codes_partisipants[i-1].ToString();
                string code_player = кп2_DataSet.DB_cell_value("Код игрока 1", "Списки участников", "Код учаcтника", code_participant);
                string name_player;
                if (code_player != "")
                {
                    name_player = кп2_DataSet.DB_cell_value("Фамилия", "Справочник игроков", "Код игрока", code_player);
                    Сетки_DataGridView.Rows[0].Cells[i].Value = name_player;
                    Сетки_DataGridView.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.White;
                    Сетки_DataGridView.Rows[i].Cells[0].Value = name_player;
                    Сетки_DataGridView.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.White;
                }
                code_player = кп2_DataSet.DB_cell_value("Код игрока 2", "Списки участников", "Код учаcтника", code_participant);
                if (code_player != "")
                {
                    name_player = кп2_DataSet.DB_cell_value("Фамилия", "Справочник игроков", "Код игрока", code_player);
                    Сетки_DataGridView.Rows[0].Cells[i].Value += "/" + name_player;
                    Сетки_DataGridView.Rows[i].Cells[0].Value += "/" + name_player;
                }
                Command.CommandText = "SELECT * FROM [Сетки] WHERE [Код участника 1] = " + code_tournament.ToString() + " ORDER BY [Код учаcтника]";

            }
            flag = 0;
            char[] inputarray;
            for (i = 1; i < Сетки_DataGridView.ColumnCount; i++)
                for (int j = i + 1; j < Сетки_DataGridView.ColumnCount; j++)
                {
                    inputarray = draws[flag, 0].ToCharArray();
                    Array.Reverse(inputarray);
                    Сетки_DataGridView.Rows[j].Cells[i].Value = new string(inputarray);
                    inputarray = draws[flag, 1].ToCharArray();
                    Array.Reverse(inputarray);
                    Сетки_DataGridView.Rows[j].Cells[i].Value += "  " + new string(inputarray);
                    inputarray = draws[flag, 2].ToCharArray();
                    Array.Reverse(inputarray);
                    Сетки_DataGridView.Rows[j].Cells[i].Value += "  " + new string(inputarray);

                    Сетки_DataGridView.Rows[i].Cells[j].Value = draws[flag, 0];
                    Сетки_DataGridView.Rows[i].Cells[j].Value += "  "  + draws[flag, 1];
                    Сетки_DataGridView.Rows[i].Cells[j].Value += "  " + draws[flag, 2];
                    flag++;
                }
        }
        private void button_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand Command;
            Command = new global::System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbConnection Connection;
            Connection = new global::System.Data.OleDb.OleDbConnection();
            Command.Connection = Connection;
            Connection.ConnectionString = global::kp2_2.Properties.Settings.Default.kp2ConnectionString;
            Connection.Open();
            /*удалить лишние записи*/
            Command.CommandText = "DELETE FROM [Сетки] WHERE [Код турнира] = " + code_tournament.ToString();
            Command.ExecuteNonQuery();
            Command.CommandText = "DELETE FROM [Расписание] WHERE [Код турнира] = " + code_tournament.ToString();
            Command.ExecuteNonQuery();
            /*обновление сетки и расписания*/
            generate();
            Command.CommandText = "SELECT * FROM [Списки участников] WHERE [Код турнира] = " + code_tournament.ToString() + " ORDER BY [Код учаcтника]";
            System.Data.OleDb.OleDbDataReader Reader = Command.ExecuteReader();
            int[] codes_partisipants = new int[number_of_participants];
            int i = 0;
            while (Reader.Read())
            {
                codes_partisipants[i] = (int)Reader[0];
                i++;
            }
            Reader.Close();
            Connection.Close();
            Connection.Open();
            Command.CommandText = "SELECT count (*) FROM [Сетки] WHERE [Код турнира] = " + code_tournament.ToString();
            int a = (int)Command.ExecuteScalar();
            Command.CommandText = "SELECT [Счёт первого сета], [Счёт второго сета], [Счёт третьего сета] FROM [Сетки] WHERE [Код турнира] = " + code_tournament.ToString() + " ORDER BY [Код матча]";
            Reader = Command.ExecuteReader();
            string[,] draws = new string[a, 3];
            i = 0;
            while (Reader.Read())
            {
                draws[i, 0] = (string)Reader[0];
                draws[i, 1] = (string)Reader[1];
                draws[i, 2] = (string)Reader[2];
                i++;
            }
            Reader.Close();
            Connection.Close();

            /*заполнение DataGridView*/
            Сетки_DataGridView.ColumnCount = number_of_participants + 1;
            Сетки_DataGridView.RowCount = number_of_participants + 1;
            for (int k = 0; k < Сетки_DataGridView.ColumnCount; k++)
                Сетки_DataGridView.Rows[k].Cells[k].Style.BackColor = System.Drawing.Color.Gray;
            for (i = 1; i < Сетки_DataGridView.ColumnCount; i++)
            {
                string code_participant = codes_partisipants[i - 1].ToString();
                string code_player = кп2_DataSet.DB_cell_value("Код игрока 1", "Списки участников", "Код учаcтника", code_participant);
                string name_player;
                if (code_player != "")
                {
                    name_player = кп2_DataSet.DB_cell_value("Фамилия", "Справочник игроков", "Код игрока", code_player);
                    Сетки_DataGridView.Rows[0].Cells[i].Value = name_player;
                    Сетки_DataGridView.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.White;
                    Сетки_DataGridView.Rows[i].Cells[0].Value = name_player;
                    Сетки_DataGridView.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.White;
                }
                code_player = кп2_DataSet.DB_cell_value("Код игрока 2", "Списки участников", "Код учаcтника", code_participant);
                if (code_player != "")
                {
                    name_player = кп2_DataSet.DB_cell_value("Фамилия", "Справочник игроков", "Код игрока", code_player);
                    Сетки_DataGridView.Rows[0].Cells[i].Value += "/" + name_player;
                    Сетки_DataGridView.Rows[i].Cells[0].Value += "/" + name_player;
                }
                Command.CommandText = "SELECT * FROM [Сетки] WHERE [Код участника 1] = " + code_tournament.ToString() + " ORDER BY [Код учаcтника]";

            }
            a = 0;
            char[] inputarray;
            for (i = 1; i < Сетки_DataGridView.ColumnCount; i++)
                for (int j = i + 1; j < Сетки_DataGridView.ColumnCount; j++)
                {
                    inputarray = draws[a, 0].ToCharArray();
                    Array.Reverse(inputarray);
                    Сетки_DataGridView.Rows[j].Cells[i].Value = new string(inputarray);
                    inputarray = draws[a, 1].ToCharArray();
                    Array.Reverse(inputarray);
                    Сетки_DataGridView.Rows[j].Cells[i].Value += "  " + new string(inputarray);
                    inputarray = draws[a, 2].ToCharArray();
                    Array.Reverse(inputarray);
                    Сетки_DataGridView.Rows[j].Cells[i].Value += "  " + new string(inputarray);

                    Сетки_DataGridView.Rows[i].Cells[j].Value = draws[a, 0];
                    Сетки_DataGridView.Rows[i].Cells[j].Value += "  " + draws[a, 1];
                    Сетки_DataGridView.Rows[i].Cells[j].Value += "  " + draws[a, 2];
                    a++;
                }

        }
    }
}
