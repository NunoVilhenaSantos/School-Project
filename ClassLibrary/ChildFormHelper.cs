namespace ClassLibrary;

public class ChildFormHelper
{
    public static void ShowChildForm(IChildForm childForm, Panel parentPanel)
    {
        if (parentPanel.Controls.Count > 0)
        {
            var controlCollection = parentPanel.Controls[0].Controls;
            if (controlCollection != null &&
                controlCollection.Equals(childForm))
                // The child form is already in the panel
                return;
            if (controlCollection.Owner.Equals(childForm))
                return;
            if (controlCollection.Owner.Equals(childForm))
                return;

            // unica condição que é verdadeira
            if (controlCollection.Owner.ToString().Equals(childForm.ToString()))
                return;
        }

        try
        {
            // Close any existing child form in the panel
            if (parentPanel.Controls.Count > 0)
            {
                var activeForm = parentPanel.Controls[0] as Form;
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm.Dispose();
                }
            }

            // Add the new child form to the panel
            childForm.ShowForm();
            parentPanel.Controls.Add(childForm as Form);
            parentPanel.Tag = childForm;
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during execution
            MessageBox.Show($"Error: {ex.Message}");
        }
    }
}