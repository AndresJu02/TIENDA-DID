using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TIENDA_DID
{
    public partial class Form1 : Form
    {
        // --- Configuración ---
        private readonly string _apiKey = "tpD8CvI2Zt$xjxEq1wj1TW5kUAW!JBwP";
        private DidwwApi api;



        // Clase para los items del ListBox (solo números)
        private class AvailableDidItem
        {
            public string Number { get; set; }
            public string AvailableId { get; set; }
            public string DidGroupId { get; set; }
            public override string ToString() => Number;
        }

        // Clase segura para ComboBoxes (países, ciudades, regiones, tipos)
        private class ComboItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }

        // Clase para items de LstGroups (prefijos)
        private class GroupItem
        {
            public string Text { get; set; }
            public string GroupId { get; set; }
            public override string ToString() => Text;
        }

        public Form1()
        {
            InitializeComponent();
            api = new DidwwApi(_apiKey);

            // Estado inicial UI
            try { btnBuy.Enabled = false; } catch { }
            try { lstNumbers.Enabled = false; } catch { }
            try { LstGroups.Enabled = false; } catch { }

            // Enlazo handlers con seguridad (si ya están enlazados en el diseñador no se duplicarán)
            try { LstGroups.SelectedIndexChanged -= LstGroups_SelectedIndexChanged; } catch { }
            try { LstGroups.SelectedIndexChanged += LstGroups_SelectedIndexChanged; } catch { }

            try { cmbDidTypes.SelectedIndexChanged -= cmbDidTypes_SelectedIndexChanged; } catch { }
            try { cmbDidTypes.SelectedIndexChanged += cmbDidTypes_SelectedIndexChanged; } catch { }
        }


        private async Task LoadCountriesRamdomAsync()
        {
            var countries = await api.GetCountriesRamdom();
            cmbCountriesRamdom.Items.Clear();

            foreach (var c in countries)
            {
                cmbCountriesRamdom.Items.Add(new ComboItem
                {
                    Text = c["attributes"]?["name"]?.ToString(),
                    Value = c["id"]?.ToString()
                });
            }

            cmbCountriesRamdom.DisplayMember = "Text";
            cmbCountriesRamdom.ValueMember = "Value";
        }
        private async Task LoadDidTypesRamdomAsync()
        {
            var types = await api.GetDidGroupTypesRamdom();
            cmbDidTypesRamdom.Items.Clear();

            foreach (var t in types)
            {
                cmbDidTypesRamdom.Items.Add(new ComboItem
                {
                    Text = t["attributes"]?["name"]?.ToString(),
                    Value = t["id"]?.ToString()
                });
            }

            cmbDidTypesRamdom.DisplayMember = "Text";
            cmbDidTypesRamdom.ValueMember = "Value";
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            bool enabled = await RemoteControl.IsEnabledAsync();
            if (!enabled)
            {
                MessageBox.Show("Esta aplicación ha sido deshabilitada por el administrador.");
                Application.Exit();
                return; // muy importante para evitar que el código siga
            }

            try
            {
                // Cargas iniciales
                await LoadCountriesAsync();
                await LoadDidTypesAsync();

                await LoadCountriesRamdomAsync();
                await LoadDidTypesRamdomAsync();


                // Enlazo otros handlers (evito duplicados)
                try { cmbCountries.SelectedIndexChanged -= cmbCountries_SelectedIndexChanged; } catch { }
                try { cmbCountries.SelectedIndexChanged += cmbCountries_SelectedIndexChanged; } catch { }

                try { lstNumbers.SelectedIndexChanged -= lstNumbers_SelectedIndexChanged; } catch { }
                try { lstNumbers.SelectedIndexChanged += lstNumbers_SelectedIndexChanged; } catch { }


                cmbQtyRamdom.Items.Clear();
                cmbQtyRamdom.Items.Add("1");
                cmbQtyRamdom.Items.Add("2");
                cmbQtyRamdom.Items.Add("5");
                cmbQtyRamdom.Items.Add("10");
                cmbQtyRamdom.Items.Add("20");

                cmbQtyRamdom.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                ShowError("Error en carga inicial", ex);
            }
        }

        // ------------------------------
        // Carga de datos (países, tipos, ciudades, regiones)
        // ------------------------------
        private async Task LoadCountriesAsync()
        {
            var countries = await api.GetCountries();
            cmbCountries.Items.Clear();

            foreach (var c in countries)
            {
                string name = c["attributes"]?["name"]?.ToString() ?? "(sin nombre)";
                string id = c["id"]?.ToString();
                cmbCountries.Items.Add(new ComboItem { Text = name, Value = id });
            }

            cmbCountries.DisplayMember = "Text";
            cmbCountries.ValueMember = "Value";
            cmbCountries.SelectedIndex = -1;
        }

        private async Task LoadDidTypesAsync()
        {
            var types = await api.GetDidGroupTypes();
            cmbDidTypes.Items.Clear();

            foreach (var t in types)
            {
                string name = t["attributes"]?["name"]?.ToString() ?? "(sin nombre)";
                string id = t["id"]?.ToString();
                cmbDidTypes.Items.Add(new ComboItem { Text = name, Value = id });
            }

            cmbDidTypes.DisplayMember = "Text";
            cmbDidTypes.ValueMember = "Value";
            cmbDidTypes.SelectedIndex = -1;
        }

        private async Task LoadCitiesAsync(string countryId)
        {
            var cities = await api.GetCities(countryId);
            cmbCities.Items.Clear();

            foreach (var c in cities)
            {
                string name = c["attributes"]?["name"]?.ToString() ?? "(sin nombre)";
                string id = c["id"]?.ToString();
                cmbCities.Items.Add(new ComboItem { Text = name, Value = id });
            }

            cmbCities.DisplayMember = "Text";
            cmbCities.ValueMember = "Value";
            cmbCities.SelectedIndex = -1;
        }

        private async Task LoadRegionsAsync(string countryId)
        {
            var regions = await api.GetRegions(countryId);
            cmbRegions.Items.Clear();

            foreach (var r in regions)
            {
                string name = r["attributes"]?["name"]?.ToString() ?? "(sin nombre)";
                string id = r["id"]?.ToString();
                cmbRegions.Items.Add(new ComboItem { Text = name, Value = id });
            }

            cmbRegions.DisplayMember = "Text";
            cmbRegions.ValueMember = "Value";
            cmbRegions.SelectedIndex = -1;
        }

        // ------------------------------
        // Eventos: al cambiar país -> cargar ciudades y regiones
        // ------------------------------
        private async void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // limpiar dependientes
                cmbCities.Items.Clear();
                cmbRegions.Items.Clear();
                cmbCities.SelectedIndex = -1;
                cmbRegions.SelectedIndex = -1;
                cmbCities.Enabled = true;

                if (cmbCountries.SelectedIndex < 0) return;

                var sel = cmbCountries.SelectedItem as ComboItem;
                if (sel == null) return;

                string countryId = sel.Value;
                if (string.IsNullOrEmpty(countryId)) return;

                await LoadCitiesAsync(countryId);
                await LoadRegionsAsync(countryId);
            }
            catch (Exception ex)
            {
                ShowError("Error al cargar ciudades/regiones", ex);
            }
        }

        private void cmbDidTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si quieres comportamiento instantáneo al cambiar tipo, ponlo aquí.
        }

        // ------------------------------
        // Evento región: desactiva ciudades si hay región seleccionada
        // ------------------------------
        private void cmbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRegions.SelectedIndex >= 0)
                {
                    // región activa -> deshabilitar y limpiar ciudades
                    cmbCities.Enabled = false;
                    cmbCities.SelectedIndex = -1;
                }
                else
                {
                    // sin región -> habilitar ciudades
                    cmbCities.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ShowError("Error en cambio de región", ex);
            }
        }

        // ------------------------------
        // Botón: buscar prefijos (btnSearchPrefijos)
        // ------------------------------
        private async void btnSearchPrefijos_Click(object sender, EventArgs e)
        {
            try
            {
                LstGroups.Items.Clear();
                lstNumbers.Items.Clear();
                lstNumbers.Enabled = false;
                btnBuy.Enabled = false;
                LstGroups.Enabled = false;

                if (cmbCountries.SelectedIndex < 0 || cmbDidTypes.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona País y Tipo DID");
                    return;
                }

                var countrySel = cmbCountries.SelectedItem as ComboItem;
                var typeSel = cmbDidTypes.SelectedItem as ComboItem;

                string countryId = countrySel?.Value;
                string typeId = typeSel?.Value;

                string cityId = (cmbCities.Enabled && cmbCities.SelectedIndex >= 0) ? ((ComboItem)cmbCities.SelectedItem).Value : null;
                string regionId = (cmbRegions.SelectedIndex >= 0) ? ((ComboItem)cmbRegions.SelectedItem).Value : null;

                // Llamada al endpoint unificado para obtener did_groups/prefijos
                var didGroups = await api.GetDidGroupsPrefijos(countryId, cityId, regionId, typeId);

                // Si no hay resultados, informamos
                if (didGroups == null || !didGroups.Any())
                {
                    MessageBox.Show("No hay prefijos disponibles");
                    return;
                }

                // Llenar LstGroups con prefijos (GroupItem)
                foreach (var g in didGroups)
                {
                    string prefix = g["attributes"]?["prefix"]?.ToString();
                    string area = g["attributes"]?["area_name"]?.ToString() ?? string.Empty;
                    string gid = g["id"]?.ToString();

                    if (string.IsNullOrEmpty(prefix) || string.IsNullOrEmpty(gid)) continue;

                    string display = $"📍 {prefix}";
                    if (!string.IsNullOrEmpty(area)) display += $" — {area}";

                    LstGroups.Items.Add(new GroupItem { Text = display, GroupId = gid });
                }

                LstGroups.DisplayMember = "Text";
                LstGroups.ValueMember = "GroupId";
                LstGroups.Enabled = LstGroups.Items.Count > 0;
            }
            catch (Exception ex)
            {
                ShowError("Error en búsqueda de prefijos", ex);
            }
        }

        // ------------------------------
        // Al seleccionar un prefijo en LstGroups cargar números en lstNumbers
        // ------------------------------
        private async void LstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LstGroups.SelectedIndex < 0)
                {
                    lstNumbers.Items.Clear();
                    lstNumbers.Enabled = false;
                    btnBuy.Enabled = false;
                    return;
                }

                var sel = LstGroups.SelectedItem as GroupItem;
                if (sel == null) return;

                string groupId = sel.GroupId;
                if (string.IsNullOrEmpty(groupId)) return;

                // bloquear UI mientras carga
                lstNumbers.Items.Clear();
                lstNumbers.Enabled = false;
                btnBuy.Enabled = false;

                var available = await api.GetAvailableDids(groupId);

                if (available == null || !available.Any())
                {
                    MessageBox.Show("No hay numeraciones disponibles para ese prefijo o verifica la disponibilidad en NUMERACIÓN RAMDOM");
                    return;
                }

                foreach (var n in available)
                {
                    string number = n["attributes"]?["number"]?.ToString();
                    string availId = n["id"]?.ToString();
                    if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(availId)) continue;

                    lstNumbers.Items.Add(new AvailableDidItem
                    {
                        Number = number,
                        AvailableId = availId,
                        DidGroupId = groupId
                    });
                }

                // habilitar selección
                lstNumbers.Enabled = true;
                btnBuy.Enabled = lstNumbers.Items.Count > 0;
            }
            catch (Exception ex)
            {
                ShowError("Error al cargar numeraciones", ex);
            }
        }

        // ------------------------------
        // Selección de número: activa botón comprar
        // ------------------------------
        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnBuy.Enabled = lstNumbers.SelectedIndex >= 0;
            }
            catch (Exception ex)
            {
                ShowError("Error en selección de número", ex);
            }
        }

        // ------------------------------
        // Comprar: usa api.CreateOrder con available_did
        // ------------------------------
        private async void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstNumbers.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un número.");
                    return;
                }

                var selected = lstNumbers.SelectedItem as AvailableDidItem;

                // 🔥 Aquí consultamos el SKU válido del grupo DID
                string skuId = await api.GetValidSkuId(selected.DidGroupId);

                if (skuId == null)
                {
                    MessageBox.Show("⚠ No se encontró un SKU válido con 2 canales para este grupo DID.");
                    return;
                }

                var confirm = MessageBox.Show($"¿Está seguro de comprar el número {selected.Number}?", "Confirmar compra", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                var order = await api.CreateOrder(selected.AvailableId, skuId);
                MessageBox.Show("✅ Compra realizada:\n" + order.ToString());

                lstNumbers.Items.Clear();
                btnBuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprar: " + ex.Message);
            }
        }



        // ------------------------------
        // otros handlers vacíos que ya tenías
        // ------------------------------
        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }

        // ------------------------------
        // Helper
        // ------------------------------
        private void ShowError(string title, Exception ex)
        {
            MessageBox.Show($"{title}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbDidTypesRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void cmbCountriesRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCitiesRamdom.Items.Clear();
                cmbRegionsRamdom.Items.Clear();

                if (cmbCountriesRamdom.SelectedIndex < 0) return;

                var sel = cmbCountriesRamdom.SelectedItem as ComboItem;
                string countryId = sel.Value;

                var cities = await api.GetCitiesRamdom(countryId);
                foreach (var c in cities)
                {
                    cmbCitiesRamdom.Items.Add(new ComboItem
                    {
                        Text = c["attributes"]?["name"]?.ToString(),
                        Value = c["id"]?.ToString()
                    });
                }

                var regions = await api.GetRegionsRamdom(countryId);
                foreach (var r in regions)
                {
                    cmbRegionsRamdom.Items.Add(new ComboItem
                    {
                        Text = r["attributes"]?["name"]?.ToString(),
                        Value = r["id"]?.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                ShowError("Error al cargar ciudades/regiones", ex);
            }
        }


        private void cmbCitiesRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRegionsRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegionsRamdom.SelectedIndex >= 0)
            {
                cmbCitiesRamdom.Enabled = false;
                cmbCitiesRamdom.SelectedIndex = -1;
            }
            else
            {
                cmbCitiesRamdom.Enabled = true;
            }
        }


        private async void btnSearchPrefijosRamdom_Click(object sender, EventArgs e)
        {
            try
            {
                LstGroupsRamdom.Items.Clear();
                btnBuyRamdom.Enabled = false;

                if (cmbCountriesRamdom.SelectedIndex < 0 || cmbDidTypesRamdom.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona País y Tipo DID");
                    return;
                }

                string countryId = ((ComboItem)cmbCountriesRamdom.SelectedItem).Value;
                var typeItem = (ComboItem)cmbDidTypesRamdom.SelectedItem;

                string typeId = typeItem.Value;
                string typeName = typeItem.Text.ToLower();

                JArray groups = null;

                // 🔥 1. Si el tipo DID es MOBILE → NO pedir ciudad/region
                if (typeName.Contains("mobile"))
                {
                    // Desactivar controles
                    cmbCitiesRamdom.Enabled = false;
                    cmbRegionsRamdom.Enabled = false;

                    // Consultar prefijos móviles SIN ciudad ni región
                    groups = await api.GetDidGroups_MobileRamdom(countryId, typeId);
                }
                else
                {
                    // Activar ciudades si NO es móvil
                    cmbCitiesRamdom.Enabled = true;

                    string cityId = (cmbCitiesRamdom.Enabled && cmbCitiesRamdom.SelectedIndex >= 0)
                                    ? ((ComboItem)cmbCitiesRamdom.SelectedItem).Value
                                    : null;

                    string regionId = (cmbRegionsRamdom.SelectedIndex >= 0)
                                    ? ((ComboItem)cmbRegionsRamdom.SelectedItem).Value
                                    : null;

                    // 🔥 2. Si NO es móvil → sí debe seleccionar ciudad o región
                    if (!string.IsNullOrEmpty(cityId))
                    {
                        groups = await api.GetDidGroups_ByCityRamdom(countryId, typeId, cityId);
                    }
                    else if (!string.IsNullOrEmpty(regionId))
                    {
                        groups = await api.GetDidGroups_ByRegionRamdom(countryId, typeId, regionId);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar Ciudad o Región.");
                        return;
                    }
                }

                // Validar resultados
                if (groups == null || groups.Count == 0)
                {
                    MessageBox.Show("No hay prefijos disponibles.");
                    return;
                }

                // Llenar lista de prefijos
                foreach (var g in groups)
                {
                    string prefix = g["attributes"]?["prefix"]?.ToString();
                    string area = g["attributes"]?["area_name"]?.ToString();
                    string id = g["id"]?.ToString();

                    LstGroupsRamdom.Items.Add(new GroupItem
                    {
                        Text = $"{prefix} — {area}",
                        GroupId = id
                    });
                }

            }
            catch (Exception ex)
            {
                ShowError("Error en búsqueda de prefijos random", ex);
            }
        }




        private async void LstGroupsRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuyRamdom.Enabled = LstGroupsRamdom.SelectedIndex >= 0;
        }


        private async void btnBuyRamdom_Click(object sender, EventArgs e)
        {
            try
            {
                if (LstGroupsRamdom.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un prefijo.");
                    return;
                }

                var selected = LstGroupsRamdom.SelectedItem as GroupItem;

                string skuId = await api.GetValidSkuId(selected.GroupId);
                if (skuId == null)
                {
                    MessageBox.Show("⚠ No se encontró un SKU válido (2 canales).");
                    return;
                }

                // ✔ Obtener cantidad seleccionada
                int qty = int.Parse(cmbQtyRamdom.SelectedItem.ToString());

                var confirm = MessageBox.Show(
                    $"¿Comprar {qty} número(s) RANDOM del prefijo {selected.Text}?",
                    "Confirmar compra",
                    MessageBoxButtons.YesNo);

                if (confirm != DialogResult.Yes) return;

                // ✔ Comprar N líneas random
                var order = await api.CreateOrderRamdom(skuId, qty);

                MessageBox.Show("✅ Compra RANDOM realizada:\n" + order.ToString());

                LstGroupsRamdom.Items.Clear();
                btnBuyRamdom.Enabled = false;
            }
            catch (Exception ex)
            {
                ShowError("Error al comprar random", ex);
            }
        }


        private void cmbQtyRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BarrasSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
