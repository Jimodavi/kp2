#include "turniri_form.h"
using namespace System::Data::OleDb;

System::Void kp2::tournaments_form::Download_Button_Click(System::Object^ sender, System::EventArgs^ e)
{
	/*����������� � ��*/
	String^ connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = kp2.accdb";
	OleDbConnection^ dbConnection = gcnew OleDbConnection(connectionString);
	/*������ � ��*/
	dbConnection->Open();
	String^ query = "SELECT * FROM [�������]";
	OleDbCommand^ dbCommand = gcnew OleDbCommand(query, dbConnection);
	OleDbDataReader^ dbReader = dbCommand->ExecuteReader();
	/*���������� ������ � tournaments_form*/
	if (dbReader->HasRows==false) {
		MessageBox::Show("������ ���������� ������", "������");
	}
	else {
		while (dbReader->Read())
		dataGridView1->Rows->Add(dbReader["��� �������"], dbReader["������������"], dbReader["��� ���������"], dbReader["��� ������� ����������"], dbReader["���������� ����������"], dbReader["������"], dbReader["���������� �����"], dbReader["���� ������"], dbReader["���� �����"], dbReader["���������� ������"], dbReader["��� ����� 1"], dbReader["��� ����� 2"], dbReader["��� ����� 3"], dbReader["����� ������ ����������"], dbReader["����� ����� ����������"], dbReader["������������ �����"], dbReader["��� ���������"], dbReader["����� ���������"], dbReader["���������� ������� �������"]);
	}
	/*�������� ����������*/
	dbReader->Close();
	dbConnection->Close();

	return System::Void();
}
