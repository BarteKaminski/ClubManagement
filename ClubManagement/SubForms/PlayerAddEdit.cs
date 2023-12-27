using ClubManagement.Helpers;
using ClubManagement.Models;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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

namespace ClubManagement.SubForms
{
    public partial class PlayerAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public static int? playerId;
        public static PlayerData player;
        public PlayerAddEdit(int? selectedPlayerId = null)
        {
            playerId = selectedPlayerId;

            InitializeComponent();
            InitializeControls();
            AddFormValidation();
            if (playerId != null)
            {
                GetPlayerData();
            }

        }
        void InitializeControls()
        {
            lb_playerName.Text = "";
            this.Text = "Dodawanie zawodnika";
            string[] countries = { "PL", "EU" };
            cb_country.Properties.Items.AddRange(countries);
            string[] legs = { "L", "R", "LR" };
            cb_leg.Properties.Items.AddRange(legs);
            var positions = DBHelper.SQL_dt("select * from dbo.positions");
            lop_positions.Properties.DataSource = positions;
            lop_positions.EditValue = "";

        }
        void GetPlayerData()
        {
            var playerData = DBHelper.SQL_dt($"select top 1 * from dbo.players join dbo.playersclubdata on Pla_Id = PlC_PlayerId left join dbo.files on Pla_Id = Fil_ObjectId and Pla_EnumId = Fil_ObjectEnum where Pla_Id = {playerId}");
            if (playerData.Rows.Count > 0)
            {
                this.Text = "Edycja zawodnika";
                lb_playerName.Text = playerData.Rows[0]["Pla_FirstName"].ToString() + " " + playerData.Rows[0]["Pla_LastName"].ToString();


                int id = Convert.ToInt32(playerData.Rows[0]["Pla_Id"]);
                string firstName = playerData.Rows[0]["Pla_FirstName"].ToString();
                string lastName = playerData.Rows[0]["Pla_LastName"].ToString();
                DateTime dateOfBirth = Convert.ToDateTime(playerData.Rows[0]["Pla_DateOfBirth"]);
                string phone = playerData.Rows[0]["Pla_Phone"].ToString();
                string email = playerData.Rows[0]["Pla_Email"].ToString();
                string country = playerData.Rows[0]["Play_Country"].ToString();
                string city = playerData.Rows[0]["Pla_City"].ToString();
                string postalCode = playerData.Rows[0]["Pla_PostalCode"].ToString();
                string street = playerData.Rows[0]["Pla_Street"].ToString();
                int houseNumber = Convert.ToInt32(playerData.Rows[0]["Pla_HouseNumber"]);
                int flatNumber = Convert.ToInt32(playerData.Rows[0]["Pla_FlatNumber"]);
                string nick = playerData.Rows[0]["PlC_Nick"].ToString();
                int positionId = Convert.ToInt32(playerData.Rows[0]["PlC_PositionId"]);
                int number = Convert.ToInt32(playerData.Rows[0]["PlC_Number"]);
                string leg = playerData.Rows[0]["PlC_Leg"].ToString();
                object photoObj = playerData.Rows[0]["Fil_BinaryData"];
                byte[] photo = photoObj != DBNull.Value ? (byte[])photoObj : null;

                player = new PlayerData(id, firstName, lastName, dateOfBirth, phone, email, country, city, postalCode, street, houseNumber, flatNumber, nick, positionId, number, leg, photo);

                txt_firstname.Text = player.FirstName;
                txt_lastname.Text = player.LastName;
                dat_dateOfBirth.EditValue = player.DateOfBirth;
                txt_phoneNumber.Text = player.Phone;
                txt_email.Text = player.Email;
                cb_country.Text = player.Country;
                txt_city.Text = player.City;
                txt_postalCode.Text = player.PostalCode;
                txt_street.Text = player.Street;
                txt_homeNumber.Text = player.HouseNumber.ToString();
                //txt_.Text = player.FlatNumber.ToString();
                txt_nick.Text = player.Nick;
                lop_positions.EditValue = player.PositionId;
                txt_number.Text = player.Number.ToString();
                cb_leg.Text = player.Leg;

                if (player.Photo != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(player.Photo))
                    {
                        Image imageFromBytes = Image.FromStream(memoryStream);
                        pictureEdit1.Image = imageFromBytes;
                    }
                }

            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {


            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            int mode = playerId != null ? 2 : 1;

            if (player == null)
            {
                player = new PlayerData();
            }

            player.FirstName = txt_firstname.Text;
            player.LastName = txt_lastname.Text;
            player.DateOfBirth = Convert.ToDateTime(dat_dateOfBirth.EditValue);
            player.Phone = txt_phoneNumber.Text;
            player.Email = txt_email.Text;
            player.Country = cb_country.Text;
            player.City = txt_city.Text;
            player.PostalCode = txt_postalCode.Text;
            player.Street = txt_street.Text;
            if (!string.IsNullOrWhiteSpace(txt_homeNumber.Text))
            {
                player.HouseNumber = Convert.ToInt32(txt_homeNumber.Text);
            }
            // player.FlatNumber = Convert.ToInt32(txt_.Text);
            player.Nick = txt_nick.Text;
            if (!string.IsNullOrWhiteSpace(lop_positions.EditValue.ToString()))
            {
                player.PositionId = Convert.ToInt32(lop_positions.EditValue);
            }
            if (!string.IsNullOrWhiteSpace(txt_number.Text))
            {
                player.Number = Convert.ToInt32(txt_number.Text);
            }
            player.Leg = cb_leg.Text;
            DBHelper.AddEditPlayer(mode, player, MainForm.loggedUserId);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btn_photo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png;";
                openFileDialog.Title = "Wybierz zdjęcie";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imgPath = openFileDialog.FileName;
                    byte[] imgByteArray = ImgHelper.GetImageAsByteArray(imgPath);
                    string fileName = Path.GetFileName(imgPath);
                    string fileExtension = Path.GetExtension(imgPath);
                    long fileSizeInBytes = new FileInfo(imgPath).Length;
                    string fileSizeInKB = (fileSizeInBytes / 1024).ToString();
                    FileData file = new FileData(fileName, fileSizeInKB, fileExtension, 1, playerId, 0, imgByteArray);
                    if (DBHelper.AddFile(file, MainForm.loggedUserId))
                    {
                        //  svgImageBox1.SvgImage = SvgImage.FromFile(imgPath);
                        pictureEdit1.Image = Image.FromFile(imgPath);
                    }
                }
            }
        }
        void AddFormValidation()
        {
            ConditionValidationRule notEmptyFirstName = new ConditionValidationRule();
            notEmptyFirstName.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyFirstName.ErrorText = "Imię jest wymagane";
            notEmptyFirstName.ErrorType = ErrorType.Critical;
            ConditionValidationRule notEmptyLastName = new ConditionValidationRule();
            notEmptyLastName.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyLastName.ErrorText = "Nazwisko jest wymagane";
            notEmptyLastName.ErrorType = ErrorType.Critical;
            dxValidationProvider1.SetValidationRule(txt_firstname, notEmptyFirstName);
            dxValidationProvider1.SetValidationRule(txt_lastname, notEmptyLastName);

        }
    }
}