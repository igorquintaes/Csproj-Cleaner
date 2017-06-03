using System.Windows.Forms;

namespace CsprojCleaner.App.WindowsForms.Contracts
{
    public interface IFormOpener
    {
        void ShowModelessForm<TForm>() where TForm : Form;
        DialogResult ShowModalForm<TForm>() where TForm : Form;
        TForm GetModelessForm<TForm>() where TForm : Form;
    }
}