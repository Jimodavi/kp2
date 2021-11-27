#pragma once

namespace kp2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для tournaments_form
	/// </summary>
	public ref class tournaments_form : public System::Windows::Forms::Form
	{
	public:
		tournaments_form(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~tournaments_form()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^ dataGridView1;
	protected:



















	private: System::Windows::Forms::Button^ Download_Button;
	private: System::Windows::Forms::DataGridViewLinkColumn^ Code_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Name_Tournament;
	private: System::Windows::Forms::DataGridViewLinkColumn^ Code_Category_Tournament;
	private: System::Windows::Forms::DataGridViewLinkColumn^ Code_System_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Participants_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Type_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Nubber_Groups_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Date_Begining_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Date_End_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Courts_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Cort1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Court2;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Court3;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Time_Begin_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Time_End_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Length_Match_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ FIO_Director_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Phone_Number_Director_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Seeded_Tournament;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->Download_Button = (gcnew System::Windows::Forms::Button());
			this->Code_Tournament = (gcnew System::Windows::Forms::DataGridViewLinkColumn());
			this->Name_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Category_Tournament = (gcnew System::Windows::Forms::DataGridViewLinkColumn());
			this->Code_System_Tournament = (gcnew System::Windows::Forms::DataGridViewLinkColumn());
			this->Number_Participants_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Type_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Nubber_Groups_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Date_Begining_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Date_End_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Number_Courts_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Cort1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Court2 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Court3 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Time_Begin_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Time_End_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Length_Match_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->FIO_Director_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Phone_Number_Director_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Number_Seeded_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(19) {
				this->Code_Tournament,
					this->Name_Tournament, this->Code_Category_Tournament, this->Code_System_Tournament, this->Number_Participants_Tournament, this->Type_Tournament,
					this->Nubber_Groups_Tournament, this->Date_Begining_Tournament, this->Date_End_Tournament, this->Number_Courts_Tournament, this->Code_Cort1,
					this->Code_Court2, this->Code_Court3, this->Time_Begin_Tournament, this->Time_End_Tournament, this->Length_Match_Tournament,
					this->FIO_Director_Tournament, this->Phone_Number_Director_Tournament, this->Number_Seeded_Tournament
			});
			this->dataGridView1->Location = System::Drawing::Point(-2, -1);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(925, 219);
			this->dataGridView1->TabIndex = 0;
			// 
			// Download_Button
			// 
			this->Download_Button->Location = System::Drawing::Point(25, 244);
			this->Download_Button->Name = L"Download_Button";
			this->Download_Button->Size = System::Drawing::Size(181, 41);
			this->Download_Button->TabIndex = 1;
			this->Download_Button->Text = L"Загрузить";
			this->Download_Button->UseVisualStyleBackColor = true;
			this->Download_Button->Click += gcnew System::EventHandler(this, &tournaments_form::Download_Button_Click);
			// 
			// Code_Tournament
			// 
			this->Code_Tournament->HeaderText = L"Код турнира";
			this->Code_Tournament->Name = L"Code_Tournament";
			this->Code_Tournament->ReadOnly = true;
			// 
			// Name_Tournament
			// 
			this->Name_Tournament->HeaderText = L"Наименование";
			this->Name_Tournament->Name = L"Name_Tournament";
			// 
			// Code_Category_Tournament
			// 
			this->Code_Category_Tournament->HeaderText = L"Код категории";
			this->Code_Category_Tournament->Name = L"Code_Category_Tournament";
			// 
			// Code_System_Tournament
			// 
			this->Code_System_Tournament->HeaderText = L"Код системы проведения";
			this->Code_System_Tournament->Name = L"Code_System_Tournament";
			// 
			// Number_Participants_Tournament
			// 
			this->Number_Participants_Tournament->HeaderText = L"Количество участников";
			this->Number_Participants_Tournament->Name = L"Number_Participants_Tournament";
			this->Number_Participants_Tournament->Resizable = System::Windows::Forms::DataGridViewTriState::True;
			this->Number_Participants_Tournament->SortMode = System::Windows::Forms::DataGridViewColumnSortMode::NotSortable;
			// 
			// Type_Tournament
			// 
			this->Type_Tournament->HeaderText = L"Разряд";
			this->Type_Tournament->Name = L"Type_Tournament";
			// 
			// Nubber_Groups_Tournament
			// 
			this->Nubber_Groups_Tournament->HeaderText = L"Количество групп";
			this->Nubber_Groups_Tournament->Name = L"Nubber_Groups_Tournament";
			// 
			// Date_Begining_Tournament
			// 
			this->Date_Begining_Tournament->HeaderText = L"Дата начала";
			this->Date_Begining_Tournament->Name = L"Date_Begining_Tournament";
			// 
			// Date_End_Tournament
			// 
			this->Date_End_Tournament->HeaderText = L"Дата конца";
			this->Date_End_Tournament->Name = L"Date_End_Tournament";
			// 
			// Number_Courts_Tournament
			// 
			this->Number_Courts_Tournament->HeaderText = L"Количество кортов";
			this->Number_Courts_Tournament->Name = L"Number_Courts_Tournament";
			// 
			// Code_Cort1
			// 
			this->Code_Cort1->HeaderText = L"Код корта 1";
			this->Code_Cort1->Name = L"Code_Cort1";
			// 
			// Code_Court2
			// 
			this->Code_Court2->HeaderText = L"Код корта 2";
			this->Code_Court2->Name = L"Code_Court2";
			// 
			// Code_Court3
			// 
			this->Code_Court3->HeaderText = L"Код корта 3";
			this->Code_Court3->Name = L"Code_Court3";
			// 
			// Time_Begin_Tournament
			// 
			this->Time_Begin_Tournament->HeaderText = L"Время начала проведения";
			this->Time_Begin_Tournament->Name = L"Time_Begin_Tournament";
			// 
			// Time_End_Tournament
			// 
			this->Time_End_Tournament->HeaderText = L"Время конца проведения";
			this->Time_End_Tournament->Name = L"Time_End_Tournament";
			// 
			// Length_Match_Tournament
			// 
			this->Length_Match_Tournament->HeaderText = L"Длителньость матча";
			this->Length_Match_Tournament->Name = L"Length_Match_Tournament";
			// 
			// FIO_Director_Tournament
			// 
			this->FIO_Director_Tournament->HeaderText = L"ФИО директора";
			this->FIO_Director_Tournament->Name = L"FIO_Director_Tournament";
			// 
			// Phone_Number_Director_Tournament
			// 
			this->Phone_Number_Director_Tournament->HeaderText = L"Номер директора";
			this->Phone_Number_Director_Tournament->Name = L"Phone_Number_Director_Tournament";
			// 
			// Number_Seeded_Tournament
			// 
			this->Number_Seeded_Tournament->HeaderText = L"Количество сеянных игроков";
			this->Number_Seeded_Tournament->Name = L"Number_Seeded_Tournament";
			// 
			// tournaments_form
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(924, 406);
			this->Controls->Add(this->Download_Button);
			this->Controls->Add(this->dataGridView1);
			this->Name = L"tournaments_form";
			this->Text = L"tournaments_form";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
private: System::Void Download_Button_Click(System::Object^ sender, System::EventArgs^ e);
};
}
