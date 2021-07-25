using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab7
{
    public static class FormsRunner
    {
        private static readonly IDictionary<FormType, IBaseForm> forms = new Dictionary<FormType, IBaseForm>
        {
            {FormType.Doubler, new Doubler.Doubler()},
            {FormType.GuessNumber, new GuessNumber.GuessNumber()}
        };

        public static void RunTask(FormType type)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = forms[type];
            form.InitializeComponent();

            Application.Run((Form)form);
        }
    }
}
