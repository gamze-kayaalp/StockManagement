using System.Collections.Generic;
using stokYönetimi.DAL;
using stokYönetimi.Entities;

namespace stokYönetimi.BL
{
    public class StokBL
    {
        private readonly DatabaseHelper _dbHelper;

        public StokBL()
        {
            _dbHelper = new DatabaseHelper();
        }

        public List<TemizlikUrunleri> GetTemizlikUrunleri()
        {
            return _dbHelper.GetTemizlikUrunleri();
        }
        public List<Atistirmalik> GetAllAtistirmaliklar()
        {
            return _dbHelper.GetAtistirmaliklar();


        }

        public int GetIcecekStok(int icecekId)
        {
            return _dbHelper.GetIcecekStok(icecekId);
        }

        public void UpdateIcecekStok(int icecekId, int yeniStok)
        {
            _dbHelper.UpdateIcecekStok(icecekId, yeniStok);
        }

        public int GetDondurmaStok()
        {
            return _dbHelper.GetDondurmaStok();
        }

        public void UpdateDondurmaStok(int yeniStok)
        {
            _dbHelper.UpdateDondurmaStok(yeniStok);
        }

        public int GetCipsStok()
        {
            return _dbHelper.GetCipsStok();
        }

        public void UpdateCipsStok(int yeniStok)
        {
            _dbHelper.UpdateCipsStok(yeniStok);
        }

        public List<Bakliyatlar> GetAllBakliyatlar()
        {
            return _dbHelper.GetAllBakliyatlar();
        }

        public List<Icecekler> GetIcecekler()
        {
            return _dbHelper.GetIcecekler();
        }

        public int GetKolaStok()
        {
            return _dbHelper.GetKolaStok();
        }
        public void UpdateKolaStok(int yeniStok)
        {
            _dbHelper.UpdateKolaStok(yeniStok);
        }

        public int GetSuStok()
        {
            return _dbHelper.GetSuStok();
        }

        public void UpdateSuStok(int yeniStok)
        {
            _dbHelper.UpdateSuStok(yeniStok);
        }

        public int GetCamasirSuyuStok()
        {
            return _dbHelper.GetCamasirSuyuStok();
        }

        public int GetMercimekStok()
        {
            return _dbHelper.GetMercimekStok();
        }

        public void UpdateMercimekStok(int yeniStok)
        {
            _dbHelper.UpdateMercimekStok(yeniStok);
        }

        public void UpdateCamasirSuyuStok(int yeniStok)
        {
            _dbHelper.UpdateCamasirSuyuStok(yeniStok);
        }

        public int GetFasulyeStok()
        {
            return _dbHelper.GetFasulyeStok();
        }
        public void UpdateFasulyeStok(int yeniStok)
        {
            _dbHelper.UpdateFasulyeStok(yeniStok);
        }

        public int GetNohutStok()
        {
            return _dbHelper.GetNohutStok();
        }

        public void UpdateNohutStok(int yeniStok)
        {
            _dbHelper.UpdateNohutStok(yeniStok);
        }

        public int GetYagCozucuStok()
        {
            return _dbHelper.GetYagCozucuStok();
        }

        public void UpdateYagCozucuStok(int yeniStok)
        {
            _dbHelper.UpdateYagCozucuStok(yeniStok);
        }

        public int GetCifStok()
        {
            return _dbHelper.GetCifStok();
        }

        public void UpdateCifStok(int yeniStok)
        {
            _dbHelper.UpdateCifStok(yeniStok);
        }

        public int GetSodaStok()
        {
            return _dbHelper.GetSodaStok();
        }

        public void UpdateSodaStok(int yeniStok)
        {
            _dbHelper.UpdateSodaStok(yeniStok);
        }

        public void UpdateCikolataStok(int yeniStok)
        {
            _dbHelper.UpdateCikolataStok(yeniStok);
        }
            public int GetCikolataStok()
        {
            return _dbHelper.GetCikolataStok();
        }

    }

}

