#include "main_form.h"
#include "tournaments_form.h"
#include <Windows.h>

using namespace kp2;
using namespace System;

[STAThread]

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew main_form);
	return 0;
}
System::Void kp2::main_form::Tournaments_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	tournaments_form^ novoeokno = gcnew tournaments_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно tournaments_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Schedule_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Draws_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::List_participants_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Catalog_category_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Catalog_system_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Catalog_etap_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Catalog_court_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}

System::Void kp2::main_form::Catalog_players_MenuItem_Click(System::Object^ sender, System::EventArgs^ e)
{
	main_form^ novoeokno = gcnew main_form();

	if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
	{
	}
	else {}
	return System::Void();
}