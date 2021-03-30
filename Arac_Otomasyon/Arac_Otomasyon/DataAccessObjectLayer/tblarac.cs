using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Data;
using Arac_Otomasyon.dbconn;

namespace Arac_Otomasyon.DataAccessObjectLayer
{
    class tblarac
    {
        private baglanti baglan;

        public tblarac()
        {
            baglan = new baglanti();
        }

        public DataTable kullaniciadivesifre(string kullaniciadi, string sifre)
        {
            string sorgu = string.Format("Select * From calısanlar Where kullaniciadi = @kullaniciadi and sifre = @sifre");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@kullaniciadi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciadi);

            sqlParameters[1] = new SqlParameter("@sifre", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sifre);

            return baglan.executeSelectQuery(sorgu, sqlParameters);
        }

        public bool insertmusteri(int mid, string ad, string soyad, int markaid,int motorid, int kasaid, int renkid, int şehirid, int km, int fiyat, DateTime ktarihi)
        {
            string sorgu = string.Format("insert into Musteri(mid, ad, soyad, markaid, motorid, kasaid, renkid, şehirid, km, fiyat, ktarihi)" +
                "values(@mid, @ad, @soyad, @markaid, @motorid, @kasaid, @renkid, @şehirid, @km, @fiyat, @ktarihi)");

            SqlParameter[] sqlParameters = new SqlParameter[11];

            sqlParameters[0] = new SqlParameter("@mid", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(mid);

            sqlParameters[1] = new SqlParameter("@ad", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ad);

            sqlParameters[2] = new SqlParameter("@soyad", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(soyad);

            sqlParameters[3] = new SqlParameter("@markaid", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(markaid);
                                                                    
            sqlParameters[4] = new SqlParameter("@motorid", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(motorid);

            sqlParameters[5] = new SqlParameter("@kasaid", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(kasaid);

            sqlParameters[6] = new SqlParameter("@renkid", SqlDbType.Int);
            sqlParameters[6].Value = Convert.ToInt32(renkid);

            sqlParameters[7] = new SqlParameter("@şehirid", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(şehirid);

            sqlParameters[8] = new SqlParameter("@km", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(km);

            sqlParameters[9] = new SqlParameter("@fiyat", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToInt32(fiyat);

            sqlParameters[10] = new SqlParameter("@ktarihi", SqlDbType.DateTime);
            sqlParameters[10].Value = Convert.ToDateTime(ktarihi);

            return baglan.executeInsertQuery(sorgu, sqlParameters);



        }


        public bool updatemusteri(int mid, string ad, string soyad, int markaid, int motorid, int kasaid, int renkid, int şehirid, int km, int fiyat, DateTime ktarihi)
        {
            string sorgu = string.Format("Update Musteri set ad=@ad," +
                "soyad=@soyad, markaid=@markaid, motorid=@motorid, kasaid=@kasaid, renkid=@renkid, şehirid=@şehirid, km=@km, fiyat=@fiyat, ktarihi=@ktarihi " +
                " where mid = '"  + mid + "'");

            SqlParameter[] sqlParameters = new SqlParameter[11];

           

            sqlParameters[0] = new SqlParameter("@ad", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ad);

            sqlParameters[1] = new SqlParameter("@soyad", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(soyad);

            sqlParameters[2] = new SqlParameter("@markaid", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(markaid);

            sqlParameters[3] = new SqlParameter("@motorid", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(motorid);

            sqlParameters[4] = new SqlParameter("@kasaid", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(kasaid);

            sqlParameters[5] = new SqlParameter("@renkid", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(renkid);

            sqlParameters[6] = new SqlParameter("@şehirid", SqlDbType.Int);
            sqlParameters[6].Value = Convert.ToInt32(şehirid);

            sqlParameters[7] = new SqlParameter("@km", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(km);

            sqlParameters[8] = new SqlParameter("@fiyat", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(fiyat);

            sqlParameters[9] = new SqlParameter("@ktarihi", SqlDbType.DateTime);
            sqlParameters[9].Value = Convert.ToDateTime(ktarihi);

            sqlParameters[10] = new SqlParameter("@mid", SqlDbType.Int);
            sqlParameters[10].Value = Convert.ToInt32(mid);

            return baglan.executeUpdateQuery(sorgu, sqlParameters);



        }


        public bool deletemusteri(int mid)
        {
            string sorgu = string.Format("Delete From Musteri where mid = '" + mid + "'");

            SqlParameter[] sqlParameters = new SqlParameter[11];


            return baglan.executeDeleteQuery(sorgu, sqlParameters);



        }
    }
}
