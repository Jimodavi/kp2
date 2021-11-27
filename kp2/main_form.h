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
	private: System::Windows::Forms::ToolStripMenuItem^ Tournaments_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Schedule_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Draws_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ List_participants_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ spravochniki_ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Catalog_category_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Catalog_system_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Catalog_etap_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Catalog_court_MenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ Catalog_players_MenuItem;
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
			this->Tournaments_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Schedule_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Draws_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->List_participants_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->spravochniki_ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Catalog_category_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Catalog_system_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Catalog_etap_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Catalog_court_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->Catalog_players_MenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->main_menuStrip->SuspendLayout();
			this->SuspendLayout();
			// 
			// main_menuStrip
			// 
			this->main_menuStrip->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(5) {
				this->Tournaments_MenuItem,
					this->Schedule_MenuItem, this->Draws_MenuItem, this->List_participants_MenuItem, this->spravochniki_ToolStripMenuItem
			});
			this->main_menuStrip->Location = System::Drawing::Point(0, 0);
			this->main_menuStrip->Name = L"main_menuStrip";
			this->main_menuStrip->Size = System::Drawing::Size(1245, 24);
			this->main_menuStrip->TabIndex = 0;
			this->main_menuStrip->Text = L"main_menuStrip";
			// 
			// Tournaments_MenuItem
			// 
			this->Tournaments_MenuItem->Name = L"Tournaments_MenuItem";
			this->Tournaments_MenuItem->Size = System::Drawing::Size(68, 20);
			this->Tournaments_MenuItem->Text = L"Турниры";
			this->Tournaments_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Tournaments_MenuItem_Click);
			// 
			// Schedule_MenuItem
			// 
			this->Schedule_MenuItem->Name = L"Schedule_MenuItem";
			this->Schedule_MenuItem->Size = System::Drawing::Size(84, 20);
			this->Schedule_MenuItem->Text = L"Расписание";
			this->Schedule_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Schedule_MenuItem_Click);
			// 
			// Draws_MenuItem
			// 
			this->Draws_MenuItem->Name = L"Draws_MenuItem";
			this->Draws_MenuItem->Size = System::Drawing::Size(98, 20);
			this->Draws_MenuItem->Text = L"Сетка турнира";
			this->Draws_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Draws_MenuItem_Click);
			// 
			// List_participants_MenuItem
			// 
			this->List_participants_MenuItem->Name = L"List_participants_MenuItem";
			this->List_participants_MenuItem->Size = System::Drawing::Size(125, 20);
			this->List_participants_MenuItem->Text = L"Участники турнира";
			this->List_participants_MenuItem->Click += gcnew System::EventHandler(this, &main_form::List_participants_MenuItem_Click);
			// 
			// spravochniki_ToolStripMenuItem
			// 
			this->spravochniki_ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(5) {
				this->Catalog_category_MenuItem,
					this->Catalog_system_MenuItem, this->Catalog_etap_MenuItem, this->Catalog_court_MenuItem,
					this->Catalog_players_MenuItem
			});
			this->spravochniki_ToolStripMenuItem->Name = L"spravochniki_ToolStripMenuItem";
			this->spravochniki_ToolStripMenuItem->Size = System::Drawing::Size(94, 20);
			this->spravochniki_ToolStripMenuItem->Text = L"Справочники";
			// 
			// Catalog_category_MenuItem
			// 
			this->Catalog_category_MenuItem->Name = L"Catalog_category_MenuItem";
			this->Catalog_category_MenuItem->Size = System::Drawing::Size(256, 22);
			this->Catalog_category_MenuItem->Text = L"Справочник категорий турниров";
			this->Catalog_category_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Catalog_category_MenuItem_Click);
			// 
			// Catalog_system_MenuItem
			// 
			this->Catalog_system_MenuItem->Name = L"Catalog_system_MenuItem";
			this->Catalog_system_MenuItem->Size = System::Drawing::Size(256, 22);
			this->Catalog_system_MenuItem->Text = L"Справочник систем проведения";
			this->Catalog_system_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Catalog_system_MenuItem_Click);
			// 
			// Catalog_etap_MenuItem
			// 
			this->Catalog_etap_MenuItem->Name = L"Catalog_etap_MenuItem";
			this->Catalog_etap_MenuItem->Size = System::Drawing::Size(256, 22);
			this->Catalog_etap_MenuItem->Text = L"Справочник этапов турниров";
			this->Catalog_etap_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Catalog_etap_MenuItem_Click);
			// 
			// Catalog_court_MenuItem
			// 
			this->Catalog_court_MenuItem->Name = L"Catalog_court_MenuItem";
			this->Catalog_court_MenuItem->Size = System::Drawing::Size(256, 22);
			this->Catalog_court_MenuItem->Text = L"Справочник кортов";
			this->Catalog_court_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Catalog_court_MenuItem_Click);
			// 
			// Catalog_players_MenuItem
			// 
			this->Catalog_players_MenuItem->Name = L"Catalog_players_MenuItem";
			this->Catalog_players_MenuItem->Size = System::Drawing::Size(256, 22);
			this->Catalog_players_MenuItem->Text = L"Справочник игроков";
			this->Catalog_players_MenuItem->Click += gcnew System::EventHandler(this, &main_form::Catalog_players_MenuItem_Click);
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
	private: System::Void Tournaments_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Schedule_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Draws_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void List_participants_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Catalog_category_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Catalog_system_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Catalog_etap_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Catalog_court_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Catalog_players_MenuItem_Click(System::Object^ sender, System::EventArgs^ e);
};
}
