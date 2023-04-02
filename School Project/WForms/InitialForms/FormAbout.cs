namespace School_Project.WForms.InitialForms;

public partial class FormAbout : Form
{
    public FormAbout()
    {
        InitializeComponent();
    }

    private void FormAbout_Load(object sender, EventArgs e)
    {
        KeyPreview = true;
    }


    private void WinForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) Close();
    }
}