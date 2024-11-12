using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prison_Manager
{
    public partial class fMain : Form
    {
        private List<Prisoner> originalPrisoners;
        private bool transformed = false;

        public fMain()
        {
            InitializeComponent();
            InitializeForm();
            this.Width = 1335;
            this.Height = 400;
            comboBoxSex.Items.AddRange(new string[] { "ч", "ж" });

        }
        private void InitializeForm()
        {
            numericAgeFrom.Value = 0;
            numericAgeTo.Value = 100;
            numericImprisonmentFrom.Value = 0;
            numericImprisonmentTo.Value = 50;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPrisoner.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Fullname";
            column.Name = "Full name";
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Age";
            column.Width = 40;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Sex";
            column.Name = "Sex";
            column.Width = 40;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Article";
            column.Name = "Article";
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Imprisonment";
            column.Name = "Imprisonment";
            column.Width = 75;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DateofArrest";
            column.Name = "Date of Arrest";
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Chamber";
            column.Name = "Chamber";
            column.Width = 60;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Character";
            column.Name = "Character";
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Family";
            column.Name = "Family";
            column.Width = 60;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Olderage";
            column.Name = "Older age";
            column.Width = 60;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PlaceInHierarchy";
            column.Name = "Place in the hierarchy";
            column.Width = 70;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CalculateRemainingSentence";
            column.Name = "Calculate remaining sentence";
            column.Width = 70;
            gvPrisoner.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "IsEligibleForEarlyRelease";
            column.Name = "Is eligible for early release";
            gvPrisoner.Columns.Add(column);

            originalPrisoners = new List<Prisoner>();
            originalPrisoners.Add(new Capo("Петров Петро Петрович", 36, "ч", "307: Незаконний обіг наркотиків",
                6, new DateTime(2022, 2, 24), 15.2, "Лідерські якості", true, 42, "Capo", 9, false));
            originalPrisoners.Add(new Zek("Якименко Микола Андрійович", 29, "ч", "115: Умисне вбивство",
                11, new DateTime(2018, 2, 10), 10.8, "Схильність до реабілітації", true, 12, "", 2, false));
            originalPrisoners.Add(new Stykach("Лев Назар Вітальович", 25, "ч", "149: Торгівля людьми", 8,
                new DateTime(2019, 5, 19), 8.7, "Антисоціальність", false, 22, "", 5, true));
            originalPrisoners.Add(new Zek("Невес Роман Андрійович", 40, "ч", "187: Розбій", 5, new DateTime(2023, 9, 12),
                2.5, "Агресивність", false, 12, "", 4, false));
            originalPrisoners.Add(new Zek("Дудук Давид Миколайович", 20, "ч", "115: Тяжкі тілесні ушкодження", 7,
                 new DateTime(2021, 5, 25), 14.5, "Тривожність та параноя", false, 14, "", 5, true));
            originalPrisoners.Add(new Stykach("Опанасенко Анатолій Валерійович", 45, "ч", "307: Незаконний обіг наркотиків",
                10, new DateTime(2020, 12, 19), 12.8, "Злочинний рецидивіст", true, 44, "", 5, true));
            originalPrisoners.Add(new Capo("Мередж Мар'яна Миколаївна", 25, "ж", "115: Умисне вбивство", 15,
                new DateTime(2015, 11, 5), 5.8, "Лідерські якості", true, 26, "", 5, false));
            originalPrisoners.Add(new Zek("Тодосюк Алла Валерівна", 30, "ж", "149: Торгівля людьми", 14, new DateTime(2017, 7, 28),
                3.5, "Маніпулятивність", false, 24, "", 4, false));
            originalPrisoners.Add(new Stykach("Романець Ольга Дмитрієвна", 27, "ж", "115: Тяжкі тілесні ушкодження", 8,
                 new DateTime(2019, 1, 25), 2.4, "Антисоціальність", true, 14, "", 4, true));
            originalPrisoners.Add(new Zek("Тимошенко Валерія Володимирівна", 24, "ж", "258: Терористичний акт", 6,
                new DateTime(2019, 11, 14), 4.8, "Замкнутість і ізоляція", false, 4, "", 4, false));
            originalPrisoners.Add(new Stykach("Лавер Анастасія Петрівна", 26, "ж", "187: Розбій", 4,
                new DateTime(2022, 2, 25), 18.4, "Схильність до реабілітації", true, 12, "", 4, true));
            originalPrisoners.Add(new Zek("Джень Олександр Кирилович", 29, "ч", "115: Умисне вбивство", 12,
                new DateTime(2016, 10, 25), 7.9, "Маніпулятивність", false, 2, "", 4, true));
            originalPrisoners.Add(new Zek("Ловець Дар'я Олегівна", 27, "ж", "258: Терористичний акт", 9,
                new DateTime(2017, 11, 21), 6.7, "Тривожність та параноя", false, 45, "", 4, true));
            originalPrisoners.Add(new Zek("Остапенко Олег Тимофійович", 34, "ч", "307: Незаконний обіг наркотиків", 8,
                new DateTime(2018, 8, 26), 11.8, "Злочинний рецидивіст", true, 4, "", 8, true));
            bindSrcPrisoners.DataSource = new BindingList<Prisoner>(originalPrisoners);
            EventArgs args = new EventArgs();
            OnResize(args);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
           {
              bindSrcPrisoners.RemoveCurrent();
           }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (transformed == true)
            {
                MessageBox.Show("Please reset filters before editing dataset", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string prisonerType = Microsoft.VisualBasic.Interaction.InputBox("Введіть тип ув'язненого (Zek або Stykach):", "Тип ув'язненого", "Zek");

                Prisoner prisoner = null;

                if (prisonerType.Equals("Zek", StringComparison.OrdinalIgnoreCase))
                {
                    prisoner = new Zek(); 
                }
                else if (prisonerType.Equals("Stykach", StringComparison.OrdinalIgnoreCase))
                {
                    prisoner = new Stykach(); 
                }
                else
                {
                    MessageBox.Show("Невірний тип ув'язненого!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fPrisoner ft = new fPrisoner(prisoner);
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    bindSrcPrisoners.Add(ft.ThePrisoner);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (transformed == true)
            {
                MessageBox.Show("Будь ласка, скиньте фільтри перед редагуванням набору даних",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Prisoner prisoner = (Prisoner)bindSrcPrisoners.List[bindSrcPrisoners.Position];

                fPrisoner ft = new fPrisoner(prisoner);

                if (ft.ShowDialog() == DialogResult.OK)
                {
                    prisoner.Sex = ft.cbSex.SelectedItem?.ToString(); 

                    bindSrcPrisoners.List[bindSrcPrisoners.Position] = prisoner;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            saveFileDialog.Title = "Зберегти у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Prisoner prisoner in bindSrcPrisoners.List)
                    {
                        string placeInHierarchy = prisoner.PlaceInHierarchy;

                        sw.Write(prisoner.Fullname + "\t" +
                                 prisoner.Age + "\t" +
                                 prisoner.Sex + "\t" +
                                 prisoner.Article + "\t" +
                                 prisoner.Imprisonment + "\t" +
                                 prisoner.DateofArrest.ToShortDateString() + "\t" + 
                                 prisoner.Chamber + "\t" +
                                 prisoner.Character + "\t" +
                                 prisoner.Family + "\t" +
                                 prisoner.Olderage + "\t" +
                                 placeInHierarchy + "\t" +
                                 prisoner.CalculateRemainingSentence + "\t" +
                                 prisoner.IsEligibleForEarlyRelease + "\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcPrisoners.Clear();
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;

                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');

                        if (split.Length < 13)
                        {
                            throw new Exception("Недостатньо даних для створення об'єкта Prisoner");
                        }

                        Prisoner prisoner = null;

                        switch (split[10])
                        {
                            case "Stykach":
                                prisoner = new Stykach(split[0], int.Parse(split[1]), split[2], split[3],
                                    int.Parse(split[4]), DateTime.Parse(split[5]), double.Parse(split[6]),
                                    split[7], bool.Parse(split[8]), int.Parse(split[9]),
                                    split[10], int.Parse(split[11]), bool.Parse(split[12]));
                                break;

                            case "Zek":
                                prisoner = new Zek(split[0], int.Parse(split[1]), split[2], split[3],
                                    int.Parse(split[4]), DateTime.Parse(split[5]), double.Parse(split[6]),
                                    split[7], bool.Parse(split[8]), int.Parse(split[9]),
                                    split[10], int.Parse(split[11]), bool.Parse(split[12]));
                                break;

                            case "Capo":
                                prisoner = new Capo(split[0], int.Parse(split[1]), split[2], split[3],
                                    int.Parse(split[4]), DateTime.Parse(split[5]), double.Parse(split[6]),
                                    split[7], bool.Parse(split[8]), int.Parse(split[9]),
                                    split[10], int.Parse(split[11]), bool.Parse(split[12]));
                                break;

                            default:
                                throw new Exception("Невідомий тип ув'язненого");
                        }

                        bindSrcPrisoners.Add(prisoner);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }


        private void btnCheck_2_Click(object sender, EventArgs e)
        {
            if (originalPrisoners == null || !originalPrisoners.Any())
            {
                MessageBox.Show("The list of prisoners is empty.");
                return;
            }
            originalPrisoners.Sort();

            bindSrcPrisoners.DataSource = originalPrisoners;
        }

        private void btnCheck_1_Click(object sender, EventArgs e)
        {
            foreach (Prisoner prisoner in bindSrcPrisoners)
            {
                string surname = prisoner.Fullname.Split(' ')[0];

                if (surname.Equals(tbPrisonerCheck.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Ув'язнений(а) сидить за статтею {prisoner.Article}", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show($"Prisoner is not in the selected dataset", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal ageFrom = numericAgeFrom.Value == 0 && numericAgeTo.Value == 100 ? 0 : numericAgeFrom.Value;
            decimal ageTo = numericAgeTo.Value == 100 && numericAgeFrom.Value == 0 ? 100 : numericAgeTo.Value;

            decimal imprisonmentFrom = numericImprisonmentFrom.Value == 0 && numericImprisonmentTo.Value == 50 ? 0 : numericImprisonmentFrom.Value;
            decimal imprisonmentTo = numericImprisonmentTo.Value == 50 && numericImprisonmentFrom.Value == 0 ? 50 : numericImprisonmentTo.Value;

            var filteredPrisoners = originalPrisoners.Where(prisoner =>

                prisoner.Age >= ageFrom && prisoner.Age <= ageTo &&

                (comboBoxSex.SelectedItem == null || prisoner.Sex == comboBoxSex.SelectedItem.ToString()) &&

                (string.IsNullOrEmpty(textBoxArticle.Text) || prisoner.Article.StartsWith(textBoxArticle.Text)) &&

                prisoner.Imprisonment >= imprisonmentFrom && prisoner.Imprisonment <= imprisonmentTo &&

                (
                    (checkBoxTrueFamily.Checked && checkBoxFalseFamily.Checked) ||
                    (checkBoxTrueFamily.Checked && prisoner.Family) ||
                    (checkBoxFalseFamily.Checked && !prisoner.Family)
                )
            ).ToList();

            bindSrcPrisoners.DataSource = filteredPrisoners;

            if (!filteredPrisoners.Any())
            {
                MessageBox.Show("Не знайдено жодного в'язня за вказаними параметрами.", "Результати фільтрації", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_2_Click(object sender, EventArgs e)
        {
            numericAgeFrom.Value = 0;
            numericAgeTo.Value = 100;
            numericImprisonmentFrom.Value = 0;
            numericImprisonmentTo.Value = 50;
            comboBoxSex.SelectedItem = null; 
            textBoxArticle.Clear(); 
            checkBoxTrueFamily.Checked = false; 
            checkBoxFalseFamily.Checked = false; 

            var filteredPrisoners = originalPrisoners.ToList();

            bindSrcPrisoners.DataSource = filteredPrisoners;

            if (!filteredPrisoners.Any())
            {
                MessageBox.Show("Не знайдено жодного в'язня.", "Результати фільтрації", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
