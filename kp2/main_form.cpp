#include "main_form.h"
#include <Windows.h>

using namespace kp2;

[STAThread]

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew main_form);
	return 0;
}