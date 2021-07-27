using System;
using System.Windows.Forms;
using Lab8;
using Lab8.StudentsEditor;

namespace Labs
{
    public class Lab8
    {
        public void TaskOne()
        {
            DateTimeReflection.WriteAllProperties();
        }

        public void TaskTwo()
        {
            Application.Run(new LinkedForm());
        }


        [STAThread]
        public void TaskThree()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StudentsEditor());
        }
    }
}
