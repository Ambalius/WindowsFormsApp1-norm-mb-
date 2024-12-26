using System;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Npgsql;
using QRCoder;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Database database = new Database();
        private int selectedTaskId = -1; // Для хранения ID выбранной задачи

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(txtTaskNumber.Text) ||
                string.IsNullOrWhiteSpace(txtTaskName.Text) ||
                string.IsNullOrWhiteSpace(txtProjectName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cmbPriority.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtAssignee.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Добавляем задачу в базу данных
                database.AddTask(
                    txtTaskNumber.Text,
                    txtTaskName.Text,
                    txtProjectName.Text,
                    txtDescription.Text,
                    cmbPriority.SelectedItem.ToString(),
                    cmbStatus.SelectedItem.ToString(),
                    txtAssignee.Text,
                    dtpCreationDate.Value
                );

                // Уведомление о успешном добавлении
                MessageBox.Show("Задача успешно добавлена в базу данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полей после добавления задачи
                ClearFormFields();

                // Обновляем DataGridView с задачами
                RefreshTasks();
            }
            catch (Exception ex)
            {
                // Ошибка при добавлении задачи
                MessageBox.Show("Ошибка при добавлении задачи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            // Проверка, если задача не выбрана
            if (selectedTaskId == -1)
            {
                MessageBox.Show("Пожалуйста, выберите задачу для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(txtTaskNumber.Text) ||
                string.IsNullOrWhiteSpace(txtTaskName.Text) ||
                string.IsNullOrWhiteSpace(txtProjectName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cmbPriority.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtAssignee.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Обновляем задачу в базе данных
                database.UpdateTask(
                    selectedTaskId,
                    txtTaskNumber.Text,
                    txtTaskName.Text,
                    txtProjectName.Text,
                    txtDescription.Text,
                    cmbPriority.SelectedItem.ToString(),
                    cmbStatus.SelectedItem.ToString(),
                    txtAssignee.Text,
                    dtpCreationDate.Value
                );

                // Уведомление о успешном обновлении
                MessageBox.Show("Задача успешно обновлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полей после редактирования
                ClearFormFields();

                // Обновляем DataGridView с задачами
                RefreshTasks();
            }
            catch (Exception ex)
            {
                // Ошибка при обновлении задачи
                MessageBox.Show("Ошибка при обновлении задачи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            // Проверка, если задача не выбрана
            if (selectedTaskId == -1)
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Удаляем задачу из базы данных
                database.DeleteTask(selectedTaskId);

                // Уведомление о успешном удалении
                MessageBox.Show("Задача успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полей после удаления
                ClearFormFields();

                // Обновляем DataGridView с задачами
                RefreshTasks();
            }
            catch (Exception ex)
            {
                // Ошибка при удалении задачи
                MessageBox.Show("Ошибка при удалении задачи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            // Если выбрана строка в DataGridView
            if (dgvTasks.SelectedRows.Count > 0)
            {
                var row = dgvTasks.SelectedRows[0];
                selectedTaskId = Convert.ToInt32(row.Cells["TaskId"].Value); // Предполагаем, что столбец с TaskId есть в DataGridView

                // Заполняем форму данными выбранной задачи
                txtTaskNumber.Text = row.Cells["TaskNumber"].Value.ToString();
                txtTaskName.Text = row.Cells["TaskName"].Value.ToString();
                txtProjectName.Text = row.Cells["ProjectName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                cmbPriority.SelectedItem = row.Cells["Priority"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                txtAssignee.Text = row.Cells["Assignee"].Value.ToString();
                dtpCreationDate.Value = Convert.ToDateTime(row.Cells["CreationDate"].Value);
            }
        }

        private void RefreshTasks()
        {
            try
            {
                // Получаем все задачи из базы данных
                DataTable tasks = database.GetAllTasks();

                // Отображаем задачи в DataGridView
                dgvTasks.DataSource = tasks;
            }
            catch (Exception ex)
            {
                // Ошибка при получении задач
                MessageBox.Show("Ошибка при получении задач: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            txtTaskNumber.Clear();
            txtTaskName.Clear();
            txtProjectName.Clear();
            txtDescription.Clear();
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtAssignee.Clear();
            dtpCreationDate.Value = DateTime.Now;

            selectedTaskId = -1; // Сбрасываем ID выбранной задачи
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            // Данные для QR-кода
            string qrData = "https://yandex.ru/images/search?img_url=https%3A%2F%2Fsun9-77.userapi.com%2Fimpg%2FYwl3qOz4AHlolCvZKlxE4Heo9WN6oiOxwTqFrg%2FsyLGCiv5n7s.jpg%3Fsize%3D1197x1197%26quality%3D95%26sign%3De695490829bafaad2dcbc486c26bfc12%26c_uniq_tag%3Dif1q0Hda_4-ZCO1TDQg-rL38S0YlWyXlrG8LCCFKUMw%26type%3Dalbum&lr=193&pos=0&rpt=simage&serp_list_type=all&source=serp&text=%D0%B4%D1%83%D1%8D%D0%B9%D0%BD%20%D0%B4%D0%B6%D0%BE%D0%BD%D1%81%D0%BE%D0%BD%20%D0%BC%D0%B5%D0%BC%D0%BD%D0%B0%D1%8F%20%D0%BA%D0%B0%D1%80%D1%82%D0%B8%D0%BD%D0%BA%D0%B0";  // Это может быть любой текст или URL

            // Генерация QR-кода
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 250,   // Ширина QR-кода
                    Height = 250   // Высота QR-кода
                }
            };

            // Генерация изображения QR-кода
            Bitmap qrCodeImage = barcodeWriter.Write(qrData);

            // Отображение QR-кода в PictureBox
            pictureBox.Image = qrCodeImage;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}