using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Prison_Manager
{
    public partial class fPrisoner : Form
    {
        public fPrisoner(Prisoner t)
        {
            ThePrisoner = t;
            InitializeComponent();
        }

        public Prisoner ThePrisoner;

        private void fPrisoner_Load(object sender, EventArgs e)
        {
            cbSex.Items.AddRange(new[] { "ч", "ж" });

            if (ThePrisoner != null)
            {
                tbFullname.Text = ThePrisoner.Fullname;
                tbAge.Text = ThePrisoner.Age.ToString();
                cbSex.SelectedItem = ThePrisoner.Sex; 
                tbArticle.Text = ThePrisoner.Article;
                tbImprisonment.Text = ThePrisoner.Imprisonment.ToString();
                tbDateofArrest.Text = ThePrisoner.DateofArrest.ToString("dd.MM.yyyy");
                tbChamber.Text = ThePrisoner.Chamber.ToString("0.0");
                tbCharacter.Text = ThePrisoner.Character;
                chbFamily.Checked = ThePrisoner.Family;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ThePrisoner.Fullname = tbFullname.Text.Trim();
                ThePrisoner.Age = int.Parse(tbAge.Text.Trim());
                ThePrisoner.Sex = cbSex.SelectedItem.ToString(); 
                ThePrisoner.Article = tbArticle.Text.Trim();
                ThePrisoner.Imprisonment = int.Parse(tbImprisonment.Text.Trim());
                ThePrisoner.DateofArrest = DateTime.ParseExact(tbDateofArrest.Text.Trim(), "dd.MM.yyyy", null);
                ThePrisoner.Chamber = double.Parse(tbChamber.Text.Trim());
                ThePrisoner.Character = tbCharacter.Text.Trim();
                ThePrisoner.Family = chbFamily.Checked;

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(tbFullname.Text) &&
                   int.TryParse(tbAge.Text, out _) &&
                   cbSex.SelectedItem != null && 
                   !string.IsNullOrWhiteSpace(tbArticle.Text) &&
                   int.TryParse(tbImprisonment.Text, out _) &&
                   DateTime.TryParseExact(tbDateofArrest.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _) &&
                   double.TryParse(tbChamber.Text, out _) &&
                   !string.IsNullOrWhiteSpace(tbCharacter.Text);
        }
    }
}
