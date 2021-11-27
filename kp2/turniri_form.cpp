#include "turniri_form.h"
using namespace System::Data::OleDb;

System::Void kp2::tournaments_form::Download_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*подключение к БД*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*запрос в БД*/
	dbConnection->Open();
	String^ query = "SELECT * FROM [Турниры]";
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);
	OleDbDataReader^ dbReader = dbCommand->ExecuteReader();
	/*заполнение данных в tournaments_form*/
	if (dbReader->HasRows==false) {
		MessageBox::Show("Ошибка считывания дянных", "Ошибка");
	}
	else {
		while (dbReader->Read())
		dataGridView1->Rows->Add(dbReader["Код турнира"], dbReader["Наименование"], dbReader["Код категории"], dbReader["Код системы проведения"], dbReader["Количество участников"], dbReader["Разряд"], dbReader["Количество групп"], dbReader["Дата начала"], dbReader["Дата конца"], dbReader["Количество кортов"], dbReader["Код корта 1"], dbReader["Код корта 2"], dbReader["Код корта 3"], dbReader["Время начала проведения"], dbReader["Время конца проведения"], dbReader["Длительность матча"], dbReader["ФИО директора"], dbReader["Номер директора"], dbReader["Количество сеянных игроков"]);
	}
	/*закрытие соединения*/
	dbReader->Close();
	dbConnection->Close();

	return System::Void();
}
