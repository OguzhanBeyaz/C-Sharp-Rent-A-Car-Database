using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Arac_Otomasyon.DataAccessObjectLayer;
using Arac_Otomasyon.PocosLayer;
using System.Data;

namespace Arac_Otomasyon.BusinessLogicLayer
{
    class aracbll
    {
        private tblarac _calısanlar;

        public aracbll()
        {
            _calısanlar = new tblarac();
        }

        public arac getSorgu(string kullaniciadi, string sifre)
        {
            arac kullaniciadigirisi = new arac();
            DataTable dataTable = new DataTable();

            dataTable = _calısanlar.kullaniciadivesifre(kullaniciadi, sifre);


            foreach (DataRow dr in dataTable.Rows)
            {
                kullaniciadigirisi.kullaniciadi = dr["kullaniciadi"].ToString();
                kullaniciadigirisi.sifre = dr["sifre"].ToString();
            }
            return kullaniciadigirisi;

            
        }


        public arac kayıt(int mid, string ad, string soyad, int markaid, int motorid, int kasaid, int renkid, int şehirid, int km, int fiyat, DateTime ktarihi)
        {
            arac ekle = new arac();
            DataTable dataTable = new DataTable();

            _calısanlar.insertmusteri(mid, ad, soyad, markaid, motorid, kasaid, renkid, şehirid, km, fiyat, ktarihi);

            foreach(DataRow dr in dataTable.Rows)
            {

                dr["mid"] = ekle.mid;
                dr["ad"] = ekle.ad;
                dr["soyad"] = ekle.soyad;
                dr["markaid"] = ekle.markaid;
                dr["motorid"] = ekle.motorid;
                dr["kasaid"] = ekle.kasaid;
                dr["renkid"] = ekle.renkid;
                dr["şehirid"] = ekle.şehirid;
                dr["km"] = ekle.km;
                dr["fiyat"] = ekle.fiyat;
                dr["ktarihi"] = ekle.ktarihi;



            }


            return ekle;

        }


        public arac gucelleme(int mid, string ad, string soyad, int markaid, int motorid, int kasaid, int renkid, int şehirid, int km, int fiyat, DateTime ktarihi)
        {
            arac ekle = new arac();
            DataTable dataTable = new DataTable();

            _calısanlar.updatemusteri(mid, ad, soyad, markaid, motorid, kasaid, renkid, şehirid, km, fiyat, ktarihi);

            foreach (DataRow dr in dataTable.Rows)
            {

                dr["mid"] = ekle.mid;
                dr["ad"] = ekle.ad;
                dr["soyad"] = ekle.soyad;
                dr["markaid"] = ekle.markaid;
                dr["motorid"] = ekle.motorid;
                dr["kasaid"] = ekle.kasaid;
                dr["renkid"] = ekle.renkid;
                dr["şehirid"] = ekle.şehirid;
                dr["km"] = ekle.km;
                dr["fiyat"] = ekle.fiyat;
                dr["ktarihi"] = ekle.ktarihi;



            }


            return ekle;

        }


        public arac silme(int mid)
        {
            arac ekle = new arac();
            DataTable dataTable = new DataTable();

            _calısanlar.deletemusteri(Convert.ToInt32(mid));

          


            return ekle;

        }
    }
}
