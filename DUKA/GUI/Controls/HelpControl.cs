using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class HelpControl : UserControl
    {
        private Button currentSelectedButton;

        public HelpControl()
        {
            InitializeComponent();
            SetupHelpContent();
            LoadGettingStarted();
        }

        private void SetupHelpContent()
        {
            // Setup event handlers cho c�c buttons
            btnGettingStarted.Click += HelpTopicButton_Click;
            btnBookingGuide.Click += HelpTopicButton_Click;
            btnEmployeeGuide.Click += HelpTopicButton_Click;
            btnFAQ.Click += HelpTopicButton_Click;
            btnContact.Click += HelpTopicButton_Click;

            // Setup mouse events cho visual feedback
            btnGettingStarted.MouseEnter += HelpButton_MouseEnter;
            btnGettingStarted.MouseLeave += HelpButton_MouseLeave;
            btnBookingGuide.MouseEnter += HelpButton_MouseEnter;
            btnBookingGuide.MouseLeave += HelpButton_MouseLeave;
            btnEmployeeGuide.MouseEnter += HelpButton_MouseEnter;
            btnEmployeeGuide.MouseLeave += HelpButton_MouseLeave;
            btnFAQ.MouseEnter += HelpButton_MouseEnter;
            btnFAQ.MouseLeave += HelpButton_MouseLeave;
            btnContact.MouseEnter += HelpButton_MouseEnter;
            btnContact.MouseLeave += HelpButton_MouseLeave;

            // Highlight button m?c ??nh
            HighlightButton(btnGettingStarted);
        }

        private void HelpTopicButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            HighlightButton(clickedButton);

            // Load n?i dung t??ng ?ng
            switch (clickedButton.Name)
            {
                case "btnGettingStarted":
                    LoadGettingStarted();
                    break;
                case "btnBookingGuide":
                    LoadBookingGuide();
                    break;
                case "btnEmployeeGuide":
                    LoadEmployeeGuide();
                    break;
                case "btnFAQ":
                    LoadFAQ();
                    break;
                case "btnContact":
                    LoadContact();
                    break;
            }
        }

        private void HelpButton_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != currentSelectedButton)
            {
                button.BackColor = Color.FromArgb(241, 245, 249);
                button.ForeColor = Color.FromArgb(59, 130, 246);
            }
        }

        private void HelpButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != currentSelectedButton)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.FromArgb(17, 24, 39);
            }
        }

        private void HighlightButton(Button selectedButton)
        {
            // Reset t?t c? buttons
            foreach (Control control in panelHelpTopics.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(17, 24, 39);
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
            }

            // Highlight button ???c ch?n
            selectedButton.BackColor = Color.FromArgb(59, 130, 246);
            selectedButton.ForeColor = Color.White;
            selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            currentSelectedButton = selectedButton;
        }

        private void LoadGettingStarted()
        {
            rtbHelpContent.Clear();
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? B?t ??u s? d?ng h? th?ng DUKA\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("1. ??ng nh?p\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Nh?p ??a ch? email v� m?t kh?u c?a b?n\n");
            rtbHelpContent.AppendText("� Click n�t \"??ng nh?p\" ?? truy c?p h? th?ng\n");
            rtbHelpContent.AppendText("� N?u qu�n m?t kh?u, click \"Qu�n m?t kh?u\"\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("2. Giao di?n ch�nh\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Menu b�n tr�i ch?a c�c ch?c n?ng ch�nh\n");
            rtbHelpContent.AppendText("� Khu v?c b�n ph?i hi?n th? n?i dung chi ti?t\n");
            rtbHelpContent.AppendText("� Header hi?n th? th�ng tin ng??i d�ng v� th?i gian\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("3. C�c ch?c n?ng ch�nh\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� ?? Dashboard: T?ng quan h? th?ng\n");
            rtbHelpContent.AppendText("� ? S�n b�ng: Qu?n l� th�ng tin s�n\n");
            rtbHelpContent.AppendText("� ?? Kh�ch h�ng: Qu?n l� kh�ch h�ng\n");
            rtbHelpContent.AppendText("� ?? Nh�n vi�n: Qu?n l� nh�n vi�n\n");
            rtbHelpContent.AppendText("� ?? D?ch v?: Qu?n l� d?ch v? v� ??t h�ng\n");
            rtbHelpContent.AppendText("� ?? B�o c�o: Xem b�o c�o v� th?ng k�\n");
            rtbHelpContent.AppendText("� ?? C�i ??t: T�y ch?nh h? th?ng\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? M?o s? d?ng:\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� S? d?ng menu b�n tr�i ?? ?i?u h??ng\n");
            rtbHelpContent.AppendText("� Click v�o c�c bi?u t??ng ?? xem chi ti?t\n");
            rtbHelpContent.AppendText("� S? d?ng n�t \"??ng xu?t\" ?? tho�t h? th?ng an to�n\n");
        }

        private void LoadBookingGuide()
        {
            rtbHelpContent.Clear();
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? H??ng d?n ??t s�n\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("1. Xem l?ch s�n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� V�o menu \"? S�n b�ng\"\n");
            rtbHelpContent.AppendText("� Ch?n s�n mu?n xem l?ch\n");
            rtbHelpContent.AppendText("� Xem c�c khung gi? tr?ng/c� kh�ch\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("2. T?o ??n ??t s�n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Click \"T?o ??n m?i\" trong ph?n ??t s�n\n");
            rtbHelpContent.AppendText("� Ch?n kh�ch h�ng (ho?c t?o kh�ch m?i)\n");
            rtbHelpContent.AppendText("� Ch?n s�n v� khung gi?\n");
            rtbHelpContent.AppendText("� Ch?n d?ch v? th�m (n?u c�)\n");
            rtbHelpContent.AppendText("� Nh?p th�ng tin thanh to�n\n");
            rtbHelpContent.AppendText("� Click \"X�c nh?n ??t s�n\"\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("3. Qu?n l� ??n ??t s�n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Xem danh s�ch ??n trong \"??t s�n\"\n");
            rtbHelpContent.AppendText("� S?a th�ng tin ??n ch?a thanh to�n\n");
            rtbHelpContent.AppendText("� H?y ??n (n?u c?n)\n");
            rtbHelpContent.AppendText("� Theo d�i tr?ng th�i thanh to�n\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("4. Thanh to�n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Ch?n ph??ng th?c thanh to�n\n");
            rtbHelpContent.AppendText("� Ti?n m?t ho?c chuy?n kho?n\n");
            rtbHelpContent.AppendText("� In h�a ??n sau khi thanh to�n\n");
        }

        private void LoadEmployeeGuide()
        {
            rtbHelpContent.Clear();
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? H??ng d?n qu?n l� nh�n vi�n\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("1. Qu?n l� th�ng tin nh�n vi�n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� V�o menu \"?? Nh�n vi�n\"\n");
            rtbHelpContent.AppendText("� Xem danh s�ch nh�n vi�n hi?n t?i\n");
            rtbHelpContent.AppendText("� Th�m nh�n vi�n m?i\n");
            rtbHelpContent.AppendText("� S?a th�ng tin nh�n vi�n\n");
            rtbHelpContent.AppendText("� X�a nh�n vi�n (n?u kh�ng c�n l�m vi?c)\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("2. Qu?n l� ca l�m vi?c\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Thi?t l?p l?ch l�m vi?c\n");
            rtbHelpContent.AppendText("� Ph�n c�ng nh�n vi�n theo ca\n");
            rtbHelpContent.AppendText("� Theo d�i gi? l�m vi?c th?c t?\n");
            rtbHelpContent.AppendText("� T�nh l??ng d?a tr�n gi? l�m\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("3. B�o c�o nh�n vi�n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Xem b�o c�o hi?u su?t\n");
            rtbHelpContent.AppendText("� Theo d�i doanh thu theo nh�n vi�n\n");
            rtbHelpContent.AppendText("� Qu?n l� l??ng v� th??ng\n");
        }

        private void LoadFAQ()
        {
            rtbHelpContent.Clear();
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            rtbHelpContent.AppendText("? C�u h?i th??ng g?p\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("Q: L�m th? n�o ?? ??t s�n?\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("A: V�o menu \"? S�n b�ng\", ch?n s�n v� khung gi? tr?ng, t?o ??n ??t s�n.\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("Q: L�m th? n�o ?? th�m kh�ch h�ng m?i?\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("A: V�o menu \"?? Kh�ch h�ng\", click \"Th�m m?i\", nh?p th�ng tin v� l?u.\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("Q: L�m th? n�o ?? xem b�o c�o?\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("A: V�o menu \"?? B�o c�o\", ch?n lo?i b�o c�o v� kho?ng th?i gian mu?n xem.\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("Q: L�m th? n�o ?? thay ??i m?t kh?u?\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("A: V�o menu \"?? C�i ??t\", ch?n \"??i m?t kh?u\", nh?p m?t kh?u c? v� m?i.\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("Q: H? th?ng b? l?i, ph?i l�m sao?\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("A: Li�n h? b? ph?n k? thu?t ho?c g?i hotline h? tr? ?? ???c gi?i quy?t nhanh ch�ng.\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("Q: L�m th? n�o ?? sao l?u d? li?u?\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("A: H? th?ng t? ??ng sao l?u h�ng ng�y. ?? sao l?u th? c�ng, v�o \"?? C�i ??t\" > \"Sao l?u\".\n");
        }

        private void LoadContact()
        {
            rtbHelpContent.Clear();
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? Li�n h? h? tr?\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? Th�ng tin li�n h?:\n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� C�ng ty: DUKA Sports Management\n");
            rtbHelpContent.AppendText("� ??a ch?: 123 ???ng ABC, Qu?n XYZ, TP.HCM\n");
            rtbHelpContent.AppendText("� ?i?n tho?i: 1900 XXX XXX\n");
            rtbHelpContent.AppendText("� Email: support@duka.vn\n");
            rtbHelpContent.AppendText("� Website: www.duka.vn\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? Gi? l�m vi?c:\n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Th? 2 - Th? 6: 8:00 - 17:30\n");
            rtbHelpContent.AppendText("� Th? 7: 8:00 - 12:00\n");
            rtbHelpContent.AppendText("� Ch? nh?t: Ngh?\n");
            rtbHelpContent.AppendText("� Hotline 24/7: 1900 XXX XXX\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? H? tr? k? thu?t:\n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Email: tech@duka.vn\n");
            rtbHelpContent.AppendText("� Telegram: @duka_support\n");
            rtbHelpContent.AppendText("� Th?i gian ph?n h?i: Trong v�ng 24h\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? H? tr? kh�ch h�ng:\n\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("� Email: customer@duka.vn\n");
            rtbHelpContent.AppendText("� Fanpage: fb.com/duka.sports\n");
            rtbHelpContent.AppendText("� Hotline: 1900 XXX XXX\n\n");

            rtbHelpContent.SelectionFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            rtbHelpContent.AppendText("?? Tr??ng h?p kh?n c?p:\n");
            rtbHelpContent.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbHelpContent.AppendText("N?u h? th?ng g?p s? c? nghi�m tr?ng, vui l�ng g?i ngay hotline kh?n c?p: 1900 XXX XXX (24/7)");
        }
    }
}