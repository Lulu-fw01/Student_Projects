using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Csv;

namespace Product_Warehouse
{
    public partial class MainForm : Form
    {
        const char separator = '>';
        NewItemForm nif;
        NewNodeForm nnf;

        /// <summary>
        /// Словарь, в котором хранятся категории и привязанные к ним продукты.
        /// </summary>
        Dictionary<string, ItemCollection> warehouseCategories;
        /// <summary>
        /// Форма для ввода пользователем параметра для csv-отчета.
        /// </summary>
        CSVNumForm csvNumForm;
        /// <summary>
        /// Форма для ввода названия для новой ветки.
        /// </summary>
        NewNodeForm cnn;

        /// <summary>
        /// Форма для подтверждения сохранения класса.
        /// </summary>
        DuWSaveW duwsForm;

        /// <summary>
        /// Текущий путь.
        /// </summary>
        string currentPath;
        /// <summary>
        /// Переменная, показывающая был ли сохранен склад.
        /// </summary>
        bool saved;

        /// <summary>
        /// Словарь с закзами.
        /// </summary>
        Dictionary<string, Order> orders;
        /// <summary>
        /// Покупатели.
        /// </summary>
        Dictionary<string, Customer> customers;
        /// <summary>
        /// текущий пользователь.
        /// </summary>
        BaseUser currentUser;
        /// <summary>
        /// Владелец склада, т.е. продавец.
        /// </summary>
        Administrator warehouseOwner;
        UserMode currentMode;

        LoginForm loginForm;
        RegistrationForm registrationForm;

        CartForm cartForm;
        public MainForm()
        {
            InitializeComponent();

            loginForm = new LoginForm();
            loginForm.EmailPasswordEntred += CheckAccountLogin;
            loginForm.VisitorModeSelected = SetVisitorMode;
            loginForm.CreateNewAccountRequest = CreateNewAccount;

            registrationForm = new RegistrationForm();
            //registrationForm.ShowDialog();
            registrationForm.EmailEntred += CheckNewLogin;
            registrationForm.AddNewCustomer = AddNewCustomer;
            registrationForm.AddNewSeller = AddNewSeller;

            // Устанавливаем максимальный размер формы равный размеру экрана.
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            // Устанавливаем минимальный размер формы, равный половине экрана.
            this.MinimumSize = new Size((int)(Screen.PrimaryScreen.WorkingArea.Width * 0.75), (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.75));
            // Устанавливаем текущий размер формы, равный минимальному.
            this.Size = MinimumSize;

            nif = new NewItemForm();
            nif.NewItemCreated = AddNewItem;

            warehouseCategories = new Dictionary<string, ItemCollection>();
            nnf = new NewNodeForm();

            addProductButton.Enabled = false;

            mainTreeView.PathSeparator = ">";

            cnn = new NewNodeForm();
            cnn.SetAsChangeNodeNameForm();
            cnn.CategoryNameEntered = ChangeNodeName;

            duwsForm = new DuWSaveW();
            duwsForm.SaveWarehouse = () => saveWarehouseToolStripMenuItem_Click(null, null);

            saved = false;

            /// Словарь с покупаелями.
            customers = new Dictionary<string, Customer>();

            currentMode = UserMode.Visitor;

            orders = new Dictionary<string, Order>();

            warehouseOwner = new Administrator("admin123", "admin123");

            cartForm = new CartForm();
            cartForm.AddNewOrder = AddNewOrder;

            LoadLastSession();
            currentMode = UserMode.Visitor;
            SetVisitorMode();
        }

        /// <summary>
        /// Добавление нового заказа.
        /// </summary>
        /// <param name="items"></param>
        private void AddNewOrder(Dictionary<string, CartItem> items)
        {
            string id = currentUser.Login + DateTime.Now;
            orders.Add(id, new Order(id, items, currentUser.Login));
            cartForm = new CartForm();
            cartForm.AddNewOrder = AddNewOrder;
        }

        private void CreateNewAccount() => registrationForm.ShowDialog();

        /// <summary>
        /// Проверка введенного логина и пароля.
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private (bool, string) CheckAccountLogin(string login, string password)
        {
            try
            {
                if (warehouseOwner != null)
                {
                    if (login == warehouseOwner.Login)
                    {
                        if (warehouseOwner.CheckPassword(password))
                        {
                            currentUser = warehouseOwner;
                            currentMode = UserMode.Adminisrator;
                            SetSellerMode();
                            return (true, "Correct");
                        }
                        else
                            return (false, "Wrong password");
                    }
                }
                if (customers.ContainsKey(login))
                {
                    if (customers[login].CheckPassword(password))
                    {
                        currentUser = customers[login];
                        currentMode = UserMode.Customer;
                        SetCustomerMode();
                        return (true, "Correct");
                    }
                    else
                        return (false, "Wrong password");
                }

                return (false, "There are no seller or customer with such login");
            }
            catch
            {
                return (false, "Exception, sorry");
            }
        }

        /// <summary>
        /// Добавление нового покупателя.
        /// </summary>
        /// <param name="newCustomer"></param>
        private void AddNewCustomer(Customer newCustomer)
        {
            customers.Add(newCustomer.Login, newCustomer);
            currentUser = newCustomer;
            currentMode = UserMode.Customer;
            SetCustomerMode();
        }


        /// <summary>
        /// Добавление нового продавца.
        /// </summary>
        /// <param name="newSeller"></param>
        private void AddNewSeller(Administrator newSeller)
        {
            createNewWarehouseToolStripMenuItem1_Click(null, null);
            currentUser = newSeller;
            warehouseOwner = newSeller;
            currentMode = UserMode.Adminisrator;
            SetSellerMode();
            
        }

        /// <summary>
        /// Проверка нового логина.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool CheckNewLogin(string login)
        {
            
            return (customers.ContainsKey(login) || warehouseOwner.Login == login);
           /* foreach (var e in users)
            {
                if (e.Login == login)
                    return true;
            }
            return false;*/
        }

        /// <summary>
        /// Установка интерфейса для режима посетителя.
        /// </summary>
        private void SetVisitorMode()
        {
            currentMode = UserMode.Visitor;
            nodeTreeContextMenuStrip.Enabled = false;
            addProductButton.Visible = false;
        }

        /// <summary>
        /// Установка интерфейса для режима покупателя.
        /// </summary>
        private void SetCustomerMode()
        {
            nodeTreeContextMenuStrip.Enabled = false;
            addProductButton.Visible = false;
        }

        /// <summary>
        /// Установка интерфейса для режима продавца.
        /// </summary>
        private void SetSellerMode()
        {
            nodeTreeContextMenuStrip.Enabled = true;
            addProductButton.Visible = true;
        }

        /// <summary>
        /// Удаление контроллера элемента.
        /// </summary>
        /// <param name="item"></param>
        private void RemoveItemFromControls(ProductControl itemControl)
        {
            try
            {
                if (mainFlowLayoutPanel.Controls.Contains(itemControl))
                { 
                    mainFlowLayoutPanel.Controls.Remove(itemControl);
                    saved = false;
                }
            }
            catch { }
        }

        /// <summary>
        /// Добавление нового продукта.
        /// </summary>
        /// <param name="newItem"></param>
        private void AddNewItem(Item newItem)
        {
            try
            {
                // Проверка, что продукта с таким артикулом не существует.
                if (CheckItemSku(newItem.SKU))
                    throw new ThisItemIsAlreadyExistsException("");

                newItem.AddItemToCart = AddItemToCart;
                var itemControl = newItem.GetControl();
                itemControl.RemoveThisControl += RemoveItemFromControls;
                itemControl.ChangesUnsaved = () => { saved = false; };
                mainFlowLayoutPanel.Controls.Add(itemControl);
                warehouseCategories[mainTreeView.SelectedNode.Name].Add(newItem);
                saved = false;
            }
            catch (ThisItemIsAlreadyExistsException)
            {
                nif.CanClose = false;
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Добавление продукта в корзину.
        /// </summary>
        /// <param name="i"></param>
        private void AddItemToCart(CartItem i)
        {
            cartForm.AddItemToCart(i);
        }

        /// <summary>
        /// Метод для проверки существования продукта с таким артикулом.
        /// </summary>
        /// <param name="sku">
        /// Артикул.
        /// </param>
        /// <returns></returns>
        private bool CheckItemSku(string sku)
        {
            try
            {
                foreach (var e in warehouseCategories)
                {
                    if (e.Value.Contains(sku))
                        return true;
                }
                return false;
            }
            catch { return false; }
        }

        /// <summary>
        /// Метод выбора нужных товаров.
        /// </summary>
        /// <param name="path"></param>
        private void SetCurrentItems(string path)
        {
            try
            {
                mainFlowLayoutPanel.Controls.Clear();
                foreach (var e in warehouseCategories)
                {
                    bool b = e.Key.Contains(path);
                    if (b)
                    {
                        foreach (Item i in e.Value)
                        {
                            i.AddItemToCart = AddItemToCart;
                            // Получение контроллера продукта.
                            var pc = i.GetControl();
                            // Установка того, что происходит при удалении продукта.
                            pc.RemoveThisControl += RemoveItemFromControls;
                            // Метка, что склад не сохранен.
                            pc.ChangesUnsaved = () => { saved = false; };
                            // Добавление контроллера.
                            mainFlowLayoutPanel.Controls.Add(pc);
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// То, что происходит после, выбора ветки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var n = e.Node;
                if (n != null)
                    addProductButton.Enabled = true;
                else throw new Exception();

                // Выводим надпись пути.
                label1.Text = n.Name;

                SetCurrentItems(n.Name);
            }
            catch { }
        }

        /// <summary>
        /// То, что происходит перед выбором ветки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            addProductButton.Enabled = false;
        }

        private void mainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           /* var n = e.Node;
            if (n != null)
                addProductButton.Enabled = true;

            var p = n.Parent;
            if (p != null)
                label1.Text = p.Name;*/
        }

        /// <summary>
        /// Нажатие на кнопку добавления новой категории(корня).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewCategoryTsmi_Click(object sender, EventArgs e)
        {
            try
            {
                nnf.CategoryNameEntered = AddNewCategory;
                nnf.ShowDialog();
            }
            catch {  }
        }

        /// <summary>
        /// Нажатие на кнопку добавления промежуточной категории(подкатегории).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSubcategoryTsmi_Click(object sender, EventArgs e)
        {
            try
            {   
                nnf.CategoryNameEntered = AddNewSubcategory;
                nnf.ShowDialog();
            }
            catch { }
        }
       

        /// <summary>
        /// Метод добавления новой категории(корня).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        private void AddNewCategory(NewNodeForm sender, string shortName)
        {
            try
            {
                var fullName = CreateFullNodeName(shortName, null);
                if (mainTreeView.Nodes.ContainsKey(fullName))
                    throw new ThisCategoryAlreadyExistsException();

                // Добавление новой категории(корня).
                // Создание категории.
                var t = new TreeNode(shortName);
                t.Name = fullName;
                mainTreeView.Nodes.Add(t);
                warehouseCategories.Add(fullName, new ItemCollection());
                saved = false;
            }
            catch (ThisCategoryAlreadyExistsException)
            {
                sender.ReadyToClose = false;
            }
            catch (Exception )
            { }
        }

        /// <summary>
        /// Метод добавления промежуточной категории(подкатегории)ю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        private void AddNewSubcategory(NewNodeForm sender, string shortName)
        {
            try
            {
                var n = mainTreeView.SelectedNode;
                var fullName = CreateFullNodeName(shortName, n);
                if (n.Nodes.ContainsKey(fullName))
                    throw new ThisCategoryAlreadyExistsException();

                // Добавление новой подкатегории.
                // Создание категории.
                /*var t = new TreeNode(shortName);
                t.Name = fullName;
                n.Nodes.Add(t);
                warehouseCategories.Add(fullName, new ItemCollection());
                saved = false;*/

                CreateNode(shortName, fullName, n);
            }
            catch (ThisCategoryAlreadyExistsException)
            {
                sender.ReadyToClose = false;
            }
            catch (Exception )
            { }
        }

        /// <summary>
        /// Метод для создания узла.
        /// </summary>
        /// <param name="shortName"></param>
        /// <param name="fullName"></param>
        /// <param name="n"></param>
        private void CreateNode(string shortName, string fullName, TreeNode n)
        {
            try
            {
                var t = new TreeNode(shortName);
                t.Name = fullName;
                n.Nodes.Add(t);
                warehouseCategories.Add(fullName, new ItemCollection());
                saved = false;
            }
            catch { }
        }

        /// <summary>
        /// Метод для составления полного имени ветки.
        /// </summary>
        /// <param name="shortName"></param>
        /// <param name="currentNode">
        /// Выбранная ветка.
        /// </param>
        /// <returns></returns>
        private string CreateFullNodeName(string shortName, TreeNode currentNode)
        {
            if (currentNode == null)
                return ':' + shortName + separator;
            else
                return currentNode.Name + shortName + separator ;
        }

        /// <summary>
        /// Метод получения короткого имени из полного имени ветки.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string GetShortNamefromFullName(TreeNode node)
        {
            var fullName = node.Name;
            var s = fullName.Split(separator);

            return s.Last();
        }

        /// <summary>
        /// Метод для сохранения данных.
        /// </summary>
        private void SaveData() => SaveData($@"warehouses{Path.DirectorySeparatorChar}testFile");
        

        /// <summary>
        /// метод для сохранения данных по выбранному пути.
        /// </summary>
        /// <param name="path"></param>
        private void SaveData(string path)
        {
            try
            {
                var bf = new BinaryFormatter();

                using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    var l = new TreeNode[mainTreeView.Nodes.Count];
                    mainTreeView.Nodes.CopyTo(l, 0);
                    bf.Serialize(fs, l);
                    bf.Serialize(fs, warehouseCategories);

                    bf.Serialize(fs, warehouseOwner);
                    bf.Serialize(fs, customers);
                    bf.Serialize(fs, orders);
                }
                saved = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Метод для загрузки данных.
        /// </summary>
        private void LoadData()
        {
            try
            {
                var f = Directory.GetFiles("warehouses");
                LoadData(f.First());
            }
            catch { }
        }

        /// <summary>
        /// Метод для загрузки данных.
        /// </summary>
        /// <param name="path"></param>
        private void LoadData(string path)
        {
            try
            {
                mainFlowLayoutPanel.Controls.Clear();
                var bf = new BinaryFormatter();

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    var nodes = (TreeNode[])bf.Deserialize(fs);
                    warehouseCategories = (Dictionary<string, ItemCollection>)bf.Deserialize(fs);

                    warehouseOwner = (Administrator)bf.Deserialize(fs);
                    customers = (Dictionary<string, Customer>)bf.Deserialize(fs);
                    orders = (Dictionary<string, Order>)bf.Deserialize(fs);

                    mainTreeView.Nodes.Clear();
                    foreach (TreeNode e in nodes)
                        mainTreeView.Nodes.Add(e);
                }
                saved = true;
                currentPath = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Событие открытия контекстного меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nodeTreeContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                var sn = mainTreeView.SelectedNode ?? null;
                if (sn == null)
                {
                    addSubcategoryTsmi.Enabled = false;
                    deleteSelectedNodeTsmi.Enabled = false;
                    changeNameTsmi.Enabled = false;
                }
                else
                {
                    addSubcategoryTsmi.Enabled = true;
                    changeNameTsmi.Enabled = true;
                    if (sn.Nodes.Count == 0 && warehouseCategories[sn.Name].Count == 0)
                        deleteSelectedNodeTsmi.Enabled = true;
                    else
                        deleteSelectedNodeTsmi.Enabled = false;
                }
            }
            catch { }
        }

        /// <summary>
        /// Событие закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => SaveLastSessionWay();



        /// <summary>
        /// Нажатие на кнопку добавления нового продукта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainTreeView.SelectedNode == null)
                {
                    addProductButton.Enabled = false;
                    throw new Exception();
                }
                nif.ShowDialog();
            }
            catch { }
        }

        /// <summary>
        /// Нажатие на кнопку удаления ветки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSelectedNodeTsmi_Click(object sender, EventArgs e)
        {
            try
            {
                var sn = mainTreeView.SelectedNode;
                warehouseCategories.Remove(sn.Name);
                sn.Remove();
                saved = false;
            }
            catch { }
        }

        private void changeNameTsmi_Click(object sender, EventArgs e) => cnn.ShowDialog();


        /// <summary>
        /// Изменение имени узла.
        /// </summary>
        /// <param name="newName"></param>
        private void ChangeNodeName(NewNodeForm sender, string newShortName)
        {
            try
            {
                var sn = mainTreeView.SelectedNode;
                var n = sn.Parent ?? null;
                var newFullName = CreateFullNodeName(newShortName, n);
                if (n == null)
                {   
                    if (mainTreeView.Nodes.ContainsKey(newFullName))
                        throw new ThisCategoryAlreadyExistsException();
                }
                else
                {
                    if (n.Nodes.ContainsKey(newFullName))
                        throw new ThisCategoryAlreadyExistsException();
                }
                
                var oldFullName = sn.Name;
                sn.Text = newShortName;

                UpdateKeys(oldFullName, newFullName);
                UpdateTreesNames(mainTreeView.SelectedNode, oldFullName, newFullName);
                saved = false;

            }
            catch (ThisCategoryAlreadyExistsException)
            {
                sender.ReadyToClose = false;
            }
            catch (Exception )
            { }
        }

        /// <summary>
        /// Метод для обновления ключей словаря.
        /// </summary>
        /// <param name="oldFullName"></param>
        /// <param name="newFullName"></param>
        private void UpdateKeys(string oldFullName, string newFullName)
        {
            try
            {
                var keys = warehouseCategories.Keys.ToList();
                var count = keys.Count;
                for (int i = 0; i < count; i++)
                {
                    if (keys[i].Contains(oldFullName))
                    {
                        warehouseCategories.Add(keys[i].Replace(oldFullName, newFullName), warehouseCategories[keys[i]]);
                        warehouseCategories.Remove(keys[i]);
                    }
                }
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Изменение путей веток.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="oldFullName"></param>
        /// <param name="newFullName"></param>
        private void UpdateTreesNames(TreeNode node, string oldFullName, string newFullName)
        {
            try
            {
                node.Name = node.Name.Replace(oldFullName, newFullName);
                if (node.Nodes != null)
                    foreach (TreeNode e in node.Nodes)
                        UpdateTreesNames(e, oldFullName, newFullName);
            }
            catch { }
        }

        /// <summary>
        /// Нажатие на кнопку создания отчета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cSVReportToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (csvNumForm == null)
            {
                csvNumForm = new CSVNumForm();
                csvNumForm.UserEnteredNum = CreateCsvReport;
            }
            csvNumForm.ShowDialog();
        }

        /// <summary>
        /// Создание csv отчета.
        /// </summary>
        /// <param name="num"></param>
        private void CreateCsvReport(int num)
        { 
            if(saveCsvFileDialog.ShowDialog() == DialogResult.Cancel) return;
            var path = saveCsvFileDialog.FileName;

            try
            {
                var columnNames = new[] { "path", "SKU", "Name", "Num in stock" };

                var rows = new List<string[]>();

                foreach (var e in warehouseCategories)
                {
                    rows.AddRange(e.Value.GetCsvRows(num, e.Key.Replace(separator.ToString(), "/")));
                }

                var csv = CsvWriter.WriteToText(columnNames, rows, ',');
                File.WriteAllText(path, csv);
            }
            catch { }

        }

        /// <summary>
        /// Нажатие на кнопку сохранения склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPath == null)
                    saveWarehouseAsToolStripMenuItem_Click(sender, e);
                else
                    SaveData(currentPath);
            }
            catch { }

        }

        /// <summary>
        /// Нажатие на кнопку загрузки склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!saved)
                    if (duwsForm.ShowDialog() == DialogResult.Cancel) return;
                loadWarehouse();
            }
            catch(Exception )
            {
                MessageBox.Show("May be file was damaged");
            }
        }

        /// <summary>
        /// Загрузка склада.
        /// </summary>
        private void loadWarehouse()
        {
            try
            {
                if (openWarehouseFD.ShowDialog() == DialogResult.Cancel) return;
                var path = openWarehouseFD.FileName;
                LoadData(path);
            }
            catch(Exception )
            {
                MessageBox.Show("May be file was damaged");
            }
        }

        /// <summary>
        /// Нажатие на кнопку создания нового склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewWarehouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!saved)
                    if (duwsForm.ShowDialog() == DialogResult.Cancel) return;

                warehouseCategories.Clear();
                mainTreeView.Nodes.Clear();
                mainFlowLayoutPanel.Controls.Clear();
                currentPath = null;
                saved = false;
                orders = new Dictionary<string, Order>();
                customers = new Dictionary<string, Customer>();
                currentUser = null;

            }
            catch { }

        }

        /// <summary>
        /// Сохранение склада перед выходом.
        /// </summary>
        private void SaveLastSessionWay()
        {
            try
            {
                var fp = Path.GetFullPath("reserves");
                if (currentPath == null || currentPath == "")
                {
                    currentPath = $@"{fp}{Path.DirectorySeparatorChar}lastWarehouse";
                }
                File.WriteAllText($@"{fp}{Path.DirectorySeparatorChar}path.txt", currentPath);
                SaveData(currentPath);
            }
            catch { }
        }

        /// <summary>
        /// Загрузка последней сессии.
        /// </summary>
        private void LoadLastSession()
        {
            try
            {
                var p = File.ReadAllText($@"reserves{Path.DirectorySeparatorChar}path.txt");
                LoadData(p);
                if($@"{Path.GetFullPath("reserves")}{Path.DirectorySeparatorChar}lastWarehouse" == currentPath)
                {
                    currentPath = null;
                }
            }
            catch { }
        }

        /// <summary>
        /// Нажатие на кнопку сохранения склада как.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveWarehouseAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveWarehouseFD.ShowDialog() == DialogResult.Cancel) return;

                var path = saveWarehouseFD.FileName;

                SaveData(path);
                currentPath = path;
            }
            catch { }
            
        }

        /// <summary>
        /// Нажатие на кнопку входа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginTsmi_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }

        private void checkOrdersTsmi_Click(object sender, EventArgs e)
        {
            if(currentMode == UserMode.Customer)
            {
                var ords = orders.Values;
                var thisOrders = from i in ords
                                 where i.CustomerLogin == currentUser.Login
                                 select i;
                var ordersForm = new OrdersForm(thisOrders.ToList());
                ordersForm.ShowDialog();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            cartForm.ShowDialog();
        }
    }
}
