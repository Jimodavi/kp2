#include "tournaments_form.h"

using namespace System::Data::OleDb;

System::Void kp2::tournaments_form::tournaments_form_Load(System::Object^ sender, System::EventArgs^ e)
{
	column_name[0] = "Код турнира";
	column_name[1] = "Наименование";
	column_name[2] = "Код категории";
	column_name[3] = "Код системы проведения";
	column_name[4] = "Количество участников";
	column_name[5] = "Разряд";
	column_name[6] = "Количество групп";
	column_name[7] = "Дата начала";
	column_name[8] = "Дата конца";
	column_name[9] = "Количество кортов";
	column_name[10] = "Код корта 1";
	column_name[11] = "Код корта 2";
	column_name[12] = "Код корта 3";
	column_name[13] = "Время начала проведения";
	column_name[14] = "Время конца проведения";
	column_name[15] = "Длительность матча";
	column_name[16] = "ФИО директора";
	column_name[17] = "Телефон директора";
	column_name[18] = "Количество сеянных участников";
	return System::Void();
}
System::Void kp2::tournaments_form::Download_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*подключение к БД*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*запрос в БД*/
	dbConnection->Open();
	String^ query = "SELECT * FROM [Турниры] ORDER BY [Код турнира]";
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);
	OleDbDataReader^ dbReader = dbCommand->ExecuteReader();
	if (dbReader->HasRows == false) {
		MessageBox::Show("Ошибка считывания данных", "Ошибка");
	}
	else {
		while(dataGridView1->RowCount - 1) dataGridView1->Rows->RemoveAt(0);
		while (dbReader->Read())
			dataGridView1->Rows->Add(dbReader[column_name[0]], dbReader[column_name[1]], dbReader[column_name[2]], dbReader[column_name[3]], dbReader[column_name[4]], dbReader[column_name[5]], dbReader[column_name[6]], dbReader[column_name[7]], dbReader[column_name[8]], dbReader[column_name[9]], dbReader[column_name[10]], dbReader[column_name[11]], dbReader[column_name[12]], dbReader[column_name[13]], dbReader[column_name[14]], dbReader[column_name[15]], dbReader[column_name[16]], dbReader[column_name[17]], dbReader[column_name[18]]);
	}
	/*закрытие соединения*/
	dbReader->Close();
	dbConnection->Close();

	return System::Void();
}
System::Void kp2::tournaments_form::Add_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*проверка*/
	if (dataGridView1->SelectedRows->Count != 1) {
		MessageBox::Show("Выберите 1 строку для добавления");
		return;
	}
	int index = dataGridView1->SelectedRows[0]->Index;
	if (dataGridView1->Rows[index]->Cells[9]->Value == nullptr) {
		MessageBox::Show("Не все данные введены");
		return;
	}
	int courts = System::Convert::ToInt32(dataGridView1->Rows[index]->Cells[9]->Value);
	for (int i = 0; i < courts; i++) if (dataGridView1->Rows[index]->Cells[10 + i]->Value == nullptr) { 
		MessageBox::Show("Не все данные введены");
		return; }
	if (dataGridView1->Rows[index]->Cells[1]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[2]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[3]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[4]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[5]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[6]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[7]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[8]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[13]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[14]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[15]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[18]->Value == nullptr) {
		MessageBox::Show("Не все данные введены");
		return;
	}
	int max = Convert::ToInt32(dataGridView1->Rows[0]->Cells[0]->Value);
	for (int i = 0; i < dataGridView1->RowCount; i++)
	{
		if (dataGridView1->Rows[i]->Cells[0]->Value != nullptr && System::Convert::ToInt32(dataGridView1->Rows[i]->Cells[0]->Value) > max)
			max = System::Convert::ToInt32(dataGridView1->Rows[i]->Cells[0]->Value);
	}
	dataGridView1->Rows[index]->Cells[0]->Value = max+1;
	String^ newelement = "'";
	for (int i = 0; i < 19; i++) {
		if (i) newelement += "', '";
		newelement += dataGridView1->Rows[index]->Cells[i]->Value;
	}
	newelement += "'";
	/*подключение к БД*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*запрос в БД*/
	dbConnection->Open();
	String^ query = "INSERT INTO [Турниры] VALUES (" + newelement + ")";
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);

	if (dbCommand->ExecuteNonQuery() != 1) MessageBox::Show("Ошибка выполнения запроса", "Ошибка");
	else MessageBox::Show("Данные добавлены");
	/*закрытие соединения*/
	dbConnection->Close();

	return System::Void();
}
System::Void kp2::tournaments_form::Update_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*проверка*/
	if (dataGridView1->SelectedRows->Count != 1) {
		MessageBox::Show("Выберите 1 строку для обновления");
		return;
	}
	int index = dataGridView1->SelectedRows[0]->Index;
	if (dataGridView1->Rows[index]->Cells[9]->Value == nullptr) {
		MessageBox::Show("Не все данные введены");
		return;
	}
	int courts = System::Convert::ToInt32(dataGridView1->Rows[index]->Cells[9]->Value);
	for (int i = 0; i < courts; i++) if (dataGridView1->Rows[index]->Cells[10 + i]->Value == nullptr) {
		MessageBox::Show("Не все данные введены");
		return;
	}
	if (dataGridView1->Rows[index]->Cells[1]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[2]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[3]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[4]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[5]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[6]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[7]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[8]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[13]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[14]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[15]->Value == nullptr ||
		dataGridView1->Rows[index]->Cells[18]->Value == nullptr) {
		MessageBox::Show("Не все данные введены");
		return;
	}
	dataGridView1->Rows[index]->Cells[0]->Value = index + 1;
	String^ newelement = "";
	for (int i = 1; i < 19; i++) {
		if (i-1) newelement += ", ";
		newelement += "["+column_name[i] + "]='";
		newelement += dataGridView1->Rows[index]->Cells[i]->Value;
		newelement += "'";
	}
	/*подключение к БД*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*запрос в БД*/
	dbConnection->Open();
	String^ query = "UPDATE [Турниры] SET " + newelement + "WHERE [Код турнира]= " + dataGridView1->Rows[index]->Cells[0]->Value;
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);

	if (dbCommand->ExecuteNonQuery() != 1) MessageBox::Show("Ошибка выполнения запроса", "Ошибка");
	else MessageBox::Show("Данные изменены");
	/*закрытие соединения*/
	dbConnection->Close();

	return System::Void();
}
System::Void kp2::tournaments_form::Delete_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*проверка*/
	if (dataGridView1->SelectedRows->Count != 1) {
		MessageBox::Show("Выберите 1 строку для удаления");
		return;
	}
	int index = dataGridView1->SelectedRows[0]->Index;
	if (dataGridView1->Rows[index]->Cells[0]->Value == nullptr) {
		MessageBox::Show("Ошибка выполнения запроса", "Ошибка");
		return;
	}
	/*подключение к БД*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*запрос в БД*/
	dbConnection->Open();
	String^ query = "DELETE FROM [Турниры] WHERE [Код турнира] = " + dataGridView1->Rows[index]->Cells[0]->Value;
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);

	if (dbCommand->ExecuteNonQuery() != 1) MessageBox::Show("Ошибка выполнения запроса", "Ошибка");
	else { 
		dataGridView1->Rows->RemoveAt(index);
		MessageBox::Show("Данные удалены");
	}

	/*закрытие соединения*/
	dbConnection->Close();
	return System::Void();
}
;