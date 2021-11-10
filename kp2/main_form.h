#pragma once

namespace kp2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// Сводка для main_form
	public ref class main_form : public System::Windows::Forms::Form
	{
	public:
		main_form(void)
		{
			InitializeComponent();
		}

	protected:
		/// Освободить все используемые ресурсы.
		~main_form()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::MenuStrip^ main_menuStrip;
	private: System::Windows::Forms::ToolStripMenuItem^ turniri_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ raspisanie_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ setka_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ uchastniki_ToolStripMenuItem;




	private: System::Windows::Forms::ToolStripMenuItem^ spravochniki_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ spravochnikkategorii_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ spravochniksistem_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ spravochniketapov_ToolStripMenuItem;




	private: System::Windows::Forms::ToolStripMenuItem^ spravochnikkornov_ToolStripMenuItem;

	private: System::Windows::Forms::ToolStripMenuItem^ spravochnikigrokov_ToolStripMenuItem;


	private:
		/// Обязательная переменная конструктора.
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->main_menuStrip = (gcnew System::Windows::Forms::MenuStrip());
			this->turniri_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->raspisanie_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->setka_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->uchastniki_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochniki_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochnikkategorii_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochniksistem_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochniketapov_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochnikkornov_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochnikigrokov_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->main_menuStrip->SuspendLayout();
			this->SuspendLayout();
			// 
			// main_menuStrip
			// 
			this->main_menuStrip->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(5) {
				this->turniri_ToolStripMenuItem,
					this->raspisanie_ToolStripMenuItem, this->setka_ToolStripMenuItem, this->uchastniki_ToolStripMenuItem, this->spravochniki_ToolStripMenuItem
			});
			this->main_menuStrip->Location = System::Drawing::Point(0, 0);
			this->main_menuStrip->Name = L"main_menuStrip";
			this->main_menuStrip->Size = System::Drawing::Size(1245, 24);
			this->main_menuStrip->TabIndex = 0;
			this->main_menuStrip->Text = L"main_menuStrip";
			// 
			// turniri_ToolStripMenuItem
			// 
			this->turniri_ToolStripMenuItem->Name = L"turniri_ToolStripMenuItem";
			this->turniri_ToolStripMenuItem->Size = System::Drawing::Size(68, 20);
			this->turniri_ToolStripMenuItem->Text = L"Турниры";
			this->turniri_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::turniri_ToolStripMenuItem_Click);
			// 
			// raspisanie_ToolStripMenuItem
			// 
			this->raspisanie_ToolStripMenuItem->Name = L"raspisanie_ToolStripMenuItem";
			this->raspisanie_ToolStripMenuItem->Size = System::Drawing::Size(84, 20);
			this->raspisanie_ToolStripMenuItem->Text = L"Расписание";
			this->raspisanie_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::raspisanie_ToolStripMenuItem_Click);
			// 
			// setka_ToolStripMenuItem
			// 
			this->setka_ToolStripMenuItem->Name = L"setka_ToolStripMenuItem";
			this->setka_ToolStripMenuItem->Size = System::Drawing::Size(98, 20);
			this->setka_ToolStripMenuItem->Text = L"Сетка турнира";
			this->setka_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::setka_ToolStripMenuItem_Click);
			// 
			// uchastniki_ToolStripMenuItem
			// 
			this->uchastniki_ToolStripMenuItem->Name = L"uchastniki_ToolStripMenuItem";
			this->uchastniki_ToolStripMenuItem->Size = System::Drawing::Size(125, 20);
			this->uchastniki_ToolStripMenuItem->Text = L"Участники турнира";
			this->uchastniki_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::uchastniki_ToolStripMenuItem_Click);
			// 
			// spravochniki_ToolStripMenuItem
			// 
			this->spravochniki_ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(5) {
				this->spravochnikkategorii_ToolStripMenuItem,
					this->spravochniksistem_ToolStripMenuItem, this->spravochniketapov_ToolStripMenuItem, this->spravochnikkornov_ToolStripMenuItem,
					this->spravochnikigrokov_ToolStripMenuItem
			});
			this->spravochniki_ToolStripMenuItem->Name = L"spravochniki_ToolStripMenuItem";
			this->spravochniki_ToolStripMenuItem->Size = System::Drawing::Size(94, 20);
			this->spravochniki_ToolStripMenuItem->Text = L"Справочники";
			// 
			// spravochnikkategorii_ToolStripMenuItem
			// 
			this->spravochnikkategorii_ToolStripMenuItem->Name = L"spravochnikkategorii_ToolStripMenuItem";
			this->spravochnikkategorii_ToolStripMenuItem->Size = System::Drawing::Size(256, 22);
			this->spravochnikkategorii_ToolStripMenuItem->Text = L"Справочник категорий турниров";
			this->spravochnikkategorii_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::spravochnikkategorii_ToolStripMenuItem_Click);
			// 
			// spravochniksistem_ToolStripMenuItem
			// 
			this->spravochniksistem_ToolStripMenuItem->Name = L"spravochniksistem_ToolStripMenuItem";
			this->spravochniksistem_ToolStripMenuItem->Size = System::Drawing::Size(256, 22);
			this->spravochniksistem_ToolStripMenuItem->Text = L"Справочник систем проведения";
			this->spravochniksistem_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::spravochniksistem_ToolStripMenuItem_Click);
			// 
			// spravochniketapov_ToolStripMenuItem
			// 
			this->spravochniketapov_ToolStripMenuItem->Name = L"spravochniketapov_ToolStripMenuItem";
			this->spravochniketapov_ToolStripMenuItem->Size = System::Drawing::Size(256, 22);
			this->spravochniketapov_ToolStripMenuItem->Text = L"Справочник этапов турниров";
			this->spravochniketapov_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::spravochniketapov_ToolStripMenuItem_Click);
			// 
			// spravochnikkornov_ToolStripMenuItem
			// 
			this->spravochnikkornov_ToolStripMenuItem->Name = L"spravochnikkornov_ToolStripMenuItem";
			this->spravochnikkornov_ToolStripMenuItem->Size = System::Drawing::Size(256, 22);
			this->spravochnikkornov_ToolStripMenuItem->Text = L"Справочник кортов";
			this->spravochnikkornov_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::spravochnikkornov_ToolStripMenuItem_Click);
			// 
			// spravochnikigrokov_ToolStripMenuItem
			// 
			this->spravochnikigrokov_ToolStripMenuItem->Name = L"spravochnikigrokov_ToolStripMenuItem";
			this->spravochnikigrokov_ToolStripMenuItem->Size = System::Drawing::Size(256, 22);
			this->spravochnikigrokov_ToolStripMenuItem->Text = L"Справочник игроков";
			this->spravochnikigrokov_ToolStripMenuItem->Click += gcnew System::EventHandler(this, &main_form::spravochnikigrokov_ToolStripMenuItem_Click);
			// 
			// main_form
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1245, 409);
			this->Controls->Add(this->main_menuStrip);
			this->MainMenuStrip = this->main_menuStrip;
			this->Name = L"main_form";
			this->Text = L"main_form";
			this->main_menuStrip->ResumeLayout(false);
			this->main_menuStrip->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void turniri_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form ^novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void raspisanie_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void setka_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void uchastniki_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void spravochnikkategorii_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void spravochniksistem_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void spravochniketapov_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void spravochnikkornov_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
	private: System::Void spravochnikigrokov_ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
		main_form^ novoeokno = gcnew main_form();

		if (novoeokno->ShowDialog(this) == Windows::Forms::DialogResult::OK)//новое окно main_form
		{
		}
		else {}
	}
};
}
