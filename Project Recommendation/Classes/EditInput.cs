namespace DB_993.Classes
{
    public class EditInput
    {
        public EditInput() { }
        public void PasswordEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        public void FalseText(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.LowercaseLetter) && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.UppercaseLetter))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar >= 'А' && e.KeyChar <= 'я')
                {
                    e.Handled = true;
                }
            }
        }

    }
}
