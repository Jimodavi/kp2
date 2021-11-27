#include "tournaments_form.h"

using namespace System::Data::OleDb;

System::Void kp2::tournaments_form::tournaments_form_Load(System::Object^ sender, System::EventArgs^ e)
{
	column_name[0] = "��� �������";
	column_name[1] = "������������";
	column_name[2] = "��� ���������";
	column_name[3] = "��� ������� ����������";
	column_name[4] = "���������� ����������";
	column_name[5] = "������";
	column_name[6] = "���������� �����";
	column_name[7] = "���� ������";
	column_name[8] = "���� �����";
	column_name[9] = "���������� ������";
	column_name[10] = "��� ����� 1";
	column_name[11] = "��� ����� 2";
	column_name[12] = "��� ����� 3";
	column_name[13] = "����� ������ ����������";
	column_name[14] = "����� ����� ����������";
	column_name[15] = "������������ �����";
	column_name[16] = "��� ���������";
	column_name[17] = "������� ���������";
	column_name[18] = "���������� ������� ����������";
	return System::Void();
}
System::Void kp2::tournaments_form::Download_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*����������� � ��*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*������ � ��*/
	dbConnection->Open();
	String^ query = "SELECT * FROM [�������] ORDER BY [��� �������]";
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);
	OleDbDataReader^ dbReader = dbCommand->ExecuteReader();
	if (dbReader->HasRows == false) {
		MessageBox::Show("������ ���������� ������", "������");
	}
	else {
		while(dataGridView1->RowCount - 1) dataGridView1->Rows->RemoveAt(0);
		while (dbReader->Read())
			dataGridView1->Rows->Add(dbReader[column_name[0]], dbReader[column_name[1]], dbReader[column_name[2]], dbReader[column_name[3]], dbReader[column_name[4]], dbReader[column_name[5]], dbReader[column_name[6]], dbReader[column_name[7]], dbReader[column_name[8]], dbReader[column_name[9]], dbReader[column_name[10]], dbReader[column_name[11]], dbReader[column_name[12]], dbReader[column_name[13]], dbReader[column_name[14]], dbReader[column_name[15]], dbReader[column_name[16]], dbReader[column_name[17]], dbReader[column_name[18]]);
	}
	/*�������� ����������*/
	dbReader->Close();
	dbConnection->Close();

	return System::Void();
}
System::Void kp2::tournaments_form::Add_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*��������*/
	if (dataGridView1->SelectedRows->Count != 1) {
		MessageBox::Show("�������� 1 ������ ��� ����������");
		return;
	}
	int index = dataGridView1->SelectedRows[0]->Index;
	if (dataGridView1->Rows[index]->Cells[9]->Value == nullptr) {
		MessageBox::Show("�� ��� ������ �������");
		return;
	}
	int courts = System::Convert::ToInt32(dataGridView1->Rows[index]->Cells[9]->Value);
	for (int i = 0; i < courts; i++) if (dataGridView1->Rows[index]->Cells[10 + i]->Value == nullptr) { 
		MessageBox::Show("�� ��� ������ �������");
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
		MessageBox::Show("�� ��� ������ �������");
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
	/*����������� � ��*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*������ � ��*/
	dbConnection->Open();
	String^ query = "INSERT INTO [�������] VALUES (" + newelement + ")";
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);

	if (dbCommand->ExecuteNonQuery() != 1) MessageBox::Show("������ ���������� �������", "������");
	else MessageBox::Show("������ ���������");
	/*�������� ����������*/
	dbConnection->Close();

	return System::Void();
}
System::Void kp2::tournaments_form::Update_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*��������*/
	if (dataGridView1->SelectedRows->Count != 1) {
		MessageBox::Show("�������� 1 ������ ��� ����������");
		return;
	}
	int index = dataGridView1->SelectedRows[0]->Index;
	if (dataGridView1->Rows[index]->Cells[9]->Value == nullptr) {
		MessageBox::Show("�� ��� ������ �������");
		return;
	}
	int courts = System::Convert::ToInt32(dataGridView1->Rows[index]->Cells[9]->Value);
	for (int i = 0; i < courts; i++) if (dataGridView1->Rows[index]->Cells[10 + i]->Value == nullptr) {
		MessageBox::Show("�� ��� ������ �������");
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
		MessageBox::Show("�� ��� ������ �������");
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
	/*����������� � ��*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*������ � ��*/
	dbConnection->Open();
	String^ query = "UPDATE [�������] SET " + newelement + "WHERE [��� �������]= " + dataGridView1->Rows[index]->Cells[0]->Value;
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);

	if (dbCommand->ExecuteNonQuery() != 1) MessageBox::Show("������ ���������� �������", "������");
	else MessageBox::Show("������ ��������");
	/*�������� ����������*/
	dbConnection->Close();

	return System::Void();
}
System::Void kp2::tournaments_form::Delete_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*��������*/
	if (dataGridView1->SelectedRows->Count != 1) {
		MessageBox::Show("�������� 1 ������ ��� ��������");
		return;
	}
	int index = dataGridView1->SelectedRows[0]->Index;
	if (dataGridView1->Rows[index]->Cells[0]->Value == nullptr) {
		MessageBox::Show("������ ���������� �������", "������");
		return;
	}
	/*����������� � ��*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*������ � ��*/
	dbConnection->Open();
	String^ query = "DELETE FROM [�������] WHERE [��� �������] = " + dataGridView1->Rows[index]->Cells[0]->Value;
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);

	if (dbCommand->ExecuteNonQuery() != 1) MessageBox::Show("������ ���������� �������", "������");
	else { 
		dataGridView1->Rows->RemoveAt(index);
		MessageBox::Show("������ �������");
	}

	/*�������� ����������*/
	dbConnection->Close();
	return System::Void();
}
;