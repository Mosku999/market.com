using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WinFormsApp11
{
    public partial class AccountForm : Form
    {
        private User currentUser;
        private decimal balance = 20000;
        private Dictionary<string, CartItem> shoppingCart;

        private Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>
        {
            {"PS VITA", 13000m},
            {"Apple Watch SE 2020", 9500m},
            {"IPhone 12", 22500m}
        };

        private Dictionary<string, decimal> additionalServices = new Dictionary<string, decimal>
        {
            {"Страховка (+2%)", 0.02m},
            {"Доп. гарантия 12 мес (+3%)", 0.03m},
            {"Ускоренная доставка (+1.5%)", 0.015m},
            {"Подарочная упаковка (+1%)", 0.01m},
            {"Отсрочка оплаты (+5%)", 0.05m},
            {"Уведомление SMS (+1%)", 0.01m},
            {"Контроль качества (+1%)", 0.01m},
            {"Быстрая обработка (+2%)", 0.02m},
            {"Звонок за 30 мин (+1%)", 0.01m},
            {"Доставка в выходные (+2%)", 0.02m},
            {"Подъем на этаж (+2%)", 0.02m},
            {"Отслеживание (+5%)", 0.05m},
            {"Курьер в костюме супергероя (+15%)", 0.15m},
            {"Музыкальное сопровождение (+10%)", 0.10m},
            {"Доставка на дроне (+20%)", 0.20m},
            {"Курьер на роликах (+8%)", 0.08m},
            {"Шоу фейерверков (+25%)", 0.25m},
            {"Курьер-динозавр (+12%)", 0.12m},
            {"Видеосвязь с курьером (+5%)", 0.05m},
            {"Мини-спектакль (+18%)", 0.18m},
            {"Тайное послание (+7%)", 0.07m},
            {"Дрон-сопровождение (+10%)", 0.10m},
            {"Живая упаковка (+15%)", 0.15m},
            {"Курьер с животным (+20%)", 0.20m},
            {"Магическое появление (+25%)", 0.25m},
            {"Курьер с роботом (+15%)", 0.15m},
            {"Тайный курьер (+10%)", 0.10m},
            {"Персональная песня (+12%)", 0.12m},
            {"Воздушные шары (+8%)", 0.08m},
            {"VR-история (+15%)", 0.15m},
            {"Экскурсия по складу (+10%)", 0.10m},
            {"Подарок из будущего (+20%)", 0.20m}
        };

        private Dictionary<string, decimal> premiumServices = new Dictionary<string, decimal>
        {
            {"Курьер в костюме супергероя (+15%)", 0.15m},
            {"Музыкальное сопровождение (+10%)", 0.10m},
            {"Доставка на дроне (+20%)", 0.20m},
            {"Курьер на роликах (+8%)", 0.08m},
            {"Шоу фейерверков (+25%)", 0.25m},
            {"Курьер-динозавр (+12%)", 0.12m},
            {"Видеосвязь с курьером (+5%)", 0.05m},
            {"Мини-спектакль (+18%)", 0.18m},
            {"Тайное послание (+7%)", 0.07m},
            {"Дрон-сопровождение (+10%)", 0.10m},
            {"Живая упаковка (+15%)", 0.15m},
            {"Курьер с животным (+20%)", 0.20m},
            {"Магическое появление (+25%)", 0.25m},
            {"Курьер с роботом (+15%)", 0.15m},
            {"Тайный курьер (+10%)", 0.10m},
            {"Персональная песня (+12%)", 0.12m},
            {"Воздушные шары (+8%)", 0.08m},
            {"VR-история (+15%)", 0.15m},
            {"Экскурсия по складу (+10%)", 0.10m},
            {"Подарок из будущего (+20%)", 0.20m}
        };

        public AccountForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            shoppingCart = new Dictionary<string, CartItem>();
            labelWelcome.Text = $"Аккаунт: {currentUser.Username}";
            UpdateBalance();

            this.cart.Click += new EventHandler(this.cart_Click);
            this.curs.Click += new EventHandler(this.curs_Click);
        }

        private void UpdateBalance()
        {
            labelBalance.Text = $"Баланс: {balance:N0} руб.";
        }

        private void BuyItem(decimal price, string itemName)
        {
            if (shoppingCart.ContainsKey(itemName))
            {
                shoppingCart[itemName].Quantity++;
            }
            else
            {
                shoppingCart[itemName] = new CartItem
                {
                    Name = itemName,
                    Price = price,
                    Quantity = 1,
                    Services = new Dictionary<string, decimal>()
                };
            }

            UpdateBalance();
            MessageBox.Show($"{itemName} добавлен в корзину", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buy1_Click(object sender, EventArgs e) => BuyItem(13000m, "PS VITA");
        private void buy2_Click(object sender, EventArgs e) => BuyItem(9500m, "Apple Watch SE 2020");
        private void buy3_Click(object sender, EventArgs e) => BuyItem(22500m, "IPhone 12");

        private void buttonLogout_Click(object sender, EventArgs e) => this.Close();

        private void cart_Click(object sender, EventArgs e)
        {
            try
            {
                if (shoppingCart.Count == 0)
                {
                    MessageBox.Show("Корзина пустая", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Form cartForm = new Form
                {
                    Text = "Корзина",
                    Width = 600,
                    Height = 550,
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    BackColor = Color.FromArgb(25, 25, 25)
                };

                ListBox listBox = new ListBox
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Microsoft Sans Serif", 10f),
                    HorizontalScrollbar = true,
                    BackColor = Color.FromArgb(40, 40, 40),
                    ForeColor = Color.White
                };

                decimal total = 0;
                foreach (var item in shoppingCart.Values)
                {
                    decimal itemTotal = item.Price * item.Quantity;
                    decimal servicesTotal = item.Services.Sum(s => itemTotal * s.Value);
                    decimal itemFullTotal = itemTotal + servicesTotal;

                    listBox.Items.Add($"{item.Name} x{item.Quantity} - {itemTotal:N0} руб.");

                    foreach (var service in item.Services)
                    {
                        listBox.Items.Add($"   + {service.Key} ({itemTotal * service.Value:N0} руб.)");
                    }

                    if (item.Services.Count > 0)
                    {
                        listBox.Items.Add($"   Итого по товару: {itemFullTotal:N0} руб.");
                    }

                    total += itemFullTotal;
                }

                Label totalLabel = new Label
                {
                    Text = $"Общая сумма: {total:N0} руб.",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleRight,
                    Height = 40,
                    Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold),
                    BackColor = Color.FromArgb(50, 50, 50),
                    ForeColor = Color.White
                };

                Button checkoutButton = new Button
                {
                    Text = "Оформить заказ",
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    BackColor = Color.FromArgb(0, 120, 215),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                checkoutButton.Click += (s, args) => ShowCheckoutForm(total, cartForm);

                Button servicesButton = new Button
                {
                    Text = "Доп. услуги",
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    BackColor = Color.FromArgb(70, 70, 70),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                servicesButton.Click += (s, args) => ShowAdditionalServices(cartForm);

                Button removeButton = new Button
                {
                    Text = "Удалить товар",
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    BackColor = Color.FromArgb(120, 0, 0),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                removeButton.Click += (s, args) => RemoveItemFromCart(listBox, cartForm);

                Button closeButton = new Button
                {
                    Text = "Закрыть",
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    BackColor = Color.FromArgb(70, 70, 70),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                closeButton.Click += (s, args) => cartForm.Close();

                Panel panel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(25, 25, 25)
                };
                panel.Controls.Add(listBox);
                panel.Controls.Add(totalLabel);
                panel.Controls.Add(checkoutButton);
                panel.Controls.Add(servicesButton);
                panel.Controls.Add(removeButton);
                panel.Controls.Add(closeButton);

                cartForm.Controls.Add(panel);
                cartForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveItemFromCart(ListBox listBox, Form cartForm)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар для удаления", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = listBox.SelectedItem.ToString();
            if (selectedItem.StartsWith("   + ") || selectedItem.StartsWith("   Итого"))
            {
                MessageBox.Show("Выберите основной товар, а не услугу", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = selectedItem.Split('x')[0].Trim();
            if (shoppingCart.ContainsKey(itemName))
            {
                shoppingCart.Remove(itemName);
                cartForm.Close();
                cart_Click(null, null); // Обновляем корзину
            }
        }

        private void ShowAdditionalServices(Form parentForm)
        {
            Form servicesForm = new Form
            {
                Text = "Дополнительные услуги",
                Width = 500,
                Height = 600,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                BackColor = Color.FromArgb(25, 25, 25)
            };

            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill,
                Appearance = TabAppearance.FlatButtons,
                ItemSize = new Size(0, 1),
                SizeMode = TabSizeMode.Fixed
            };

            TabPage basicTab = new TabPage { BackColor = Color.FromArgb(25, 25, 25) };
            TabPage premiumTab = new TabPage { BackColor = Color.FromArgb(25, 25, 25) };

            tabControl.TabPages.Add(basicTab);
            tabControl.TabPages.Add(premiumTab);

            Button basicBtn = new Button
            {
                Text = "Основные услуги",
                Location = new Point(10, 10),
                Width = 200,
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White
            };
            basicBtn.Click += (s, e) => tabControl.SelectedIndex = 0;

            Button premiumBtn = new Button
            {
                Text = "Премиум услуги",
                Location = new Point(220, 10),
                Width = 200,
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White
            };
            premiumBtn.Click += (s, e) => tabControl.SelectedIndex = 1;

            FlowLayoutPanel basicPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(40, 40, 40)
            };

            foreach (var service in additionalServices)
            {
                Button btn = new Button
                {
                    Text = service.Key,
                    Width = 450,
                    Height = 50,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(60, 60, 60),
                    ForeColor = Color.White,
                    Tag = service.Key
                };
                btn.Click += (s, e) => AddServiceToItem(btn.Tag.ToString(), service.Value, servicesForm, parentForm);
                basicPanel.Controls.Add(btn);
            }

            FlowLayoutPanel premiumPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(40, 40, 40)
            };

            foreach (var service in premiumServices)
            {
                Button btn = new Button
                {
                    Text = service.Key,
                    Width = 450,
                    Height = 50,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(80, 60, 80),
                    ForeColor = Color.White,
                    Tag = service.Key
                };
                btn.Click += (s, e) => AddServiceToItem(btn.Tag.ToString(), service.Value, servicesForm, parentForm);
                premiumPanel.Controls.Add(btn);
            }

            basicTab.Controls.Add(basicPanel);
            premiumTab.Controls.Add(premiumPanel);

            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(25, 25, 25)
            };
            mainPanel.Controls.Add(tabControl);
            mainPanel.Controls.Add(basicBtn);
            mainPanel.Controls.Add(premiumBtn);

            servicesForm.Controls.Add(mainPanel);
            servicesForm.ShowDialog();
        }

        private void AddServiceToItem(string serviceName, decimal percent, Form servicesForm, Form cartForm)
        {
            if (shoppingCart.Count == 0)
            {
                MessageBox.Show("Добавьте товары в корзину сначала", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (shoppingCart.Count == 1)
            {
                var item = shoppingCart.Values.First();
                if (!item.Services.ContainsKey(serviceName))
                {
                    item.Services.Add(serviceName, percent);
                    MessageBox.Show($"Услуга {serviceName} добавлена к {item.Name}", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Эта услуга уже добавлена к товару", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Form selectItemForm = new Form
                {
                    Text = "Выберите товар",
                    Width = 400,
                    Height = 300,
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    BackColor = Color.FromArgb(25, 25, 25)
                };

                ListBox itemsList = new ListBox
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Microsoft Sans Serif", 10f),
                    BackColor = Color.FromArgb(40, 40, 40),
                    ForeColor = Color.White
                };

                foreach (var item in shoppingCart.Values)
                {
                    itemsList.Items.Add(item.Name);
                }

                Button addButton = new Button
                {
                    Text = "Добавить услугу",
                    Dock = DockStyle.Bottom,
                    Height = 45,
                    BackColor = Color.FromArgb(0, 120, 215),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                addButton.Click += (s, args) =>
                {
                    if (itemsList.SelectedIndex != -1)
                    {
                        string selectedItem = itemsList.SelectedItem.ToString();
                        var cartItem = shoppingCart.Values.First(i => i.Name == selectedItem);

                        if (!cartItem.Services.ContainsKey(serviceName))
                        {
                            cartItem.Services.Add(serviceName, percent);
                            MessageBox.Show($"Услуга {serviceName} добавлена к {cartItem.Name}", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Эта услуга уже добавлена к товару", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        selectItemForm.Close();
                        servicesForm.Close();
                        cartForm.Close();
                        cart_Click(null, null); // Обновляем корзину
                    }
                };

                Panel panel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(25, 25, 25)
                };
                panel.Controls.Add(itemsList);
                panel.Controls.Add(addButton);

                selectItemForm.Controls.Add(panel);
                selectItemForm.ShowDialog();
            }
        }

        private void ShowCheckoutForm(decimal baseTotal, Form parentForm)
        {
            decimal deliveryCost = 0;
            decimal servicesCost = shoppingCart.Values
                .Sum(item => item.Services.Sum(s => item.Price * item.Quantity * s.Value));

            decimal total = baseTotal + servicesCost;

            Form checkoutForm = new Form
            {
                Text = "Оформление заказа",
                Width = 500,
                Height = 500,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                BackColor = Color.FromArgb(25, 25, 25)
            };

            Label addressLabel = new Label
            {
                Text = "Адрес доставки:",
                Location = new Point(20, 20),
                ForeColor = Color.White,
                AutoSize = true
            };

            TextBox addressTextBox = new TextBox
            {
                Location = new Point(20, 50),
                Width = 450,
                BackColor = Color.FromArgb(40, 40, 40),
                ForeColor = Color.White
            };

            RadioButton pickupRadio = new RadioButton
            {
                Text = "Самовывоз (бесплатно)",
                Location = new Point(20, 90),
                Checked = true,
                ForeColor = Color.White,
                AutoSize = true
            };

            RadioButton deliveryRadio = new RadioButton
            {
                Text = "Доставка (+10%)",
                Location = new Point(20, 120),
                ForeColor = Color.White,
                AutoSize = true
            };

            CheckBox insuranceCheck = new CheckBox
            {
                Text = "Страховка (+2%)",
                Location = new Point(20, 150),
                ForeColor = Color.White,
                AutoSize = true
            };

            CheckBox warrantyCheck = new CheckBox
            {
                Text = "Доп. гарантия 12 мес (+3%)",
                Location = new Point(20, 180),
                ForeColor = Color.White,
                AutoSize = true
            };

            Label servicesLabel = new Label
            {
                Text = "Выбранные услуги:",
                Location = new Point(20, 210),
                ForeColor = Color.White,
                AutoSize = true
            };

            ListBox servicesList = new ListBox
            {
                Location = new Point(20, 240),
                Width = 450,
                Height = 100,
                BackColor = Color.FromArgb(40, 40, 40),
                ForeColor = Color.White
            };

            foreach (var item in shoppingCart.Values)
            {
                foreach (var service in item.Services)
                {
                    servicesList.Items.Add($"{item.Name}: {service.Key}");
                }
            }

            Label totalLabel = new Label
            {
                Text = $"Итого: {total:N0} руб.",
                Location = new Point(20, 350),
                ForeColor = Color.White,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold)
            };

            Label deliveryTimeLabel = new Label
            {
                Text = "Примерное время доставки: " + DateTime.Now.AddDays(1).ToString("dd.MM.yyyy HH:mm"),
                Location = new Point(20, 380),
                ForeColor = Color.White,
                AutoSize = true
            };

            Button confirmButton = new Button
            {
                Text = "Подтвердить заказ",
                Location = new Point(20, 410),
                Width = 450,
                Height = 40,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            confirmButton.Click += (s, args) =>
            {
                decimal finalTotal = total;
                if (deliveryRadio.Checked)
                {
                    finalTotal *= 1.1m;
                }
                if (insuranceCheck.Checked)
                {
                    finalTotal *= 1.02m;
                }
                if (warrantyCheck.Checked)
                {
                    finalTotal *= 1.03m;
                }

                if (balance >= finalTotal)
                {
                    balance -= finalTotal;
                    UpdateBalance();
                    shoppingCart.Clear();
                    MessageBox.Show($"Заказ оформлен!\nСумма: {finalTotal:N0} руб.\nСпособ получения: {(pickupRadio.Checked ? "Самовывоз" : "Доставка")}\nАдрес: {(pickupRadio.Checked ? "Самовывоз из магазина" : addressTextBox.Text)}", "Заказ оформлен",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkoutForm.Close();
                    parentForm.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на балансе", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            deliveryRadio.CheckedChanged += (s, args) =>
            {
                decimal newTotal = total;
                if (deliveryRadio.Checked) newTotal *= 1.1m;
                if (insuranceCheck.Checked) newTotal *= 1.02m;
                if (warrantyCheck.Checked) newTotal *= 1.03m;
                totalLabel.Text = $"Итого: {newTotal:N0} руб.";
            };

            insuranceCheck.CheckedChanged += (s, args) =>
            {
                decimal newTotal = total;
                if (deliveryRadio.Checked) newTotal *= 1.1m;
                if (insuranceCheck.Checked) newTotal *= 1.02m;
                if (warrantyCheck.Checked) newTotal *= 1.03m;
                totalLabel.Text = $"Итого: {newTotal:N0} руб.";
            };

            warrantyCheck.CheckedChanged += (s, args) =>
            {
                decimal newTotal = total;
                if (deliveryRadio.Checked) newTotal *= 1.1m;
                if (insuranceCheck.Checked) newTotal *= 1.02m;
                if (warrantyCheck.Checked) newTotal *= 1.03m;
                totalLabel.Text = $"Итого: {newTotal:N0} руб.";
            };

            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(25, 25, 25),
                AutoScroll = true
            };
            panel.Controls.Add(addressLabel);
            panel.Controls.Add(addressTextBox);
            panel.Controls.Add(pickupRadio);
            panel.Controls.Add(deliveryRadio);
            panel.Controls.Add(insuranceCheck);
            panel.Controls.Add(warrantyCheck);
            panel.Controls.Add(servicesLabel);
            panel.Controls.Add(servicesList);
            panel.Controls.Add(totalLabel);
            panel.Controls.Add(deliveryTimeLabel);
            panel.Controls.Add(confirmButton);

            checkoutForm.Controls.Add(panel);
            checkoutForm.ShowDialog();
        }

        private async void curs_Click(object sender, EventArgs e)
        {
            // ... (прежний код курсов валют без изменений)
        }

        private class CartItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public Dictionary<string, decimal> Services { get; set; }
        }

        // ... (остальные методы без изменений)
    

        private class CurrencyRate
        {
            public string Buy { get; set; }
            public string Sell { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void labelBalance_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void Pokupki_Click_1(object sender, EventArgs e) { }
        private void pokupki_Click(object sender, EventArgs e) { }
    }
}