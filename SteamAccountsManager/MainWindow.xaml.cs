using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using WindowsInput;
using System.Windows.Media;

namespace SteamAccountsManager
{
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool BringWindowToTop(IntPtr hWnd);
        private List<Account> accounts = new List<Account>();
        private Account selectedAccount;
        public MainWindow()
        {
            InitializeComponent();
            if (Directory.Exists(@"C:\Program Files\Steam Account Manager"))
            {
                accounts = Serialization.Serialization.Deserealize();
            }
            else
            {
                Directory.CreateDirectory(@"C:\Program Files\Steam Account Manager");
            }
            foreach (Account account in accounts)
            {
                AccountsList.Items.Add($"{account.Name}");
            }
            AccountsList.SelectionChanged += AccountsList_SelectionChanged;
        }
        private void AccountsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (AccountsList.SelectedIndex != -1)
            {
                selectedAccount = accounts[AccountsList.SelectedIndex];
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ErorText.Text = "";
            if (NickText.Text != "" && LoginText.Text != "" && PasswordText.Password != "")
            {
                accounts.Add(new Account(NickText.Text, LoginText.Text, PasswordText.Password));
                AccountsList.Items.Add($"{NickText.Text}");
                NickText.Text = "";
                LoginText.Text = "";
                PasswordText.Password = "";
                Serialization.Serialization.Serealize(accounts);
            }
            else
                ErorText.Text = "Заполните все поля ввода";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ErorText.Text = "";
            if (selectedAccount != null)
            {
                BringWindowToTop(FindWindow(null, "Вход в Steam"));
                Thread.Sleep(40);
                new InputSimulator().Keyboard.TextEntry(selectedAccount.Login);
                Thread.Sleep(40);
                new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
                Thread.Sleep(40);
                new InputSimulator().Keyboard.TextEntry(selectedAccount.Password);
                Thread.Sleep(40);
                new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
                Thread.Sleep(40);
                new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.SPACE);
                Thread.Sleep(40);
                new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
                Thread.Sleep(40);
                new InputSimulator().Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.SPACE);
            }
            else
                ErorText.Text = "Выберите аккаунт";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ErorText.Text = "";
            if (selectedAccount != null)
            {
                accounts.Remove(selectedAccount);
                AccountsList.Items.Remove(AccountsList.Items[AccountsList.SelectedIndex]);
                Serialization.Serialization.Serealize(accounts);
            }
            else
                ErorText.Text = "Выберите аккаунт";
        }
        private void TextBlock_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            CloseButton.Foreground = Brushes.Gray;
        }
        private void TextBlock_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            CloseButton.Foreground = Brushes.WhiteSmoke;
        }
        private void CloseButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Card_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mainWindow.DragMove();
        }
    }
}
