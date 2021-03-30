using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachHang.DTO;
using System.Data.SqlClient;
using System.Web;

namespace QuanLyKhachHang.DAO
{
     class NhanVienDAO
    {

         private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
          get { if (instance == null) instance = new NhanVienDAO(); return instance; }
         private set { instance = value; }
        }

        private NhanVienDAO() { }
      
        public DataTable GetListNV()
        {
            DataTable data = DataProvider.Instance.executeQuery("select * from NHANVIEN");
            return data;
        }

        public Boolean ThemNV(string manv, string tennv,string ngaysinh, string diachi, string sdt, string gioitinh, int luong, string ngayvaolam)
        {
            string query = string.Format("insert into NHANVIEN(MANV,TENNV,NGAYSINH,DIACHI,SDT,GIOITINH,LUONG,NGAYVAOLAM) VALUES (N'{0}',N'{1}','{2}',N'{3}','{4}',N'{5}',{6},'{7}') ",manv,tennv,ngaysinh,diachi,sdt,gioitinh,luong,ngayvaolam );
            int result = DataProvider.Instance.executeNonQuery(query);
            return result >0;
        }

        public Boolean SuaNV(string manv, string tennv, string ngaysinh, string diachi, string sdt, string gioitinh, int luong, string ngayvaolam)
        {
            string query = string.Format("insert into NHANVIEN(MANV,TENNV,NGAYSINH,DIACHI,SDT,GIOITINH,LUONG,NGAYVAOLAM) VALUES (N'{0}',N'{1}','{2}',N'{3}','{4}',N'{5}',{6},'{7}') ", manv, tennv, ngaysinh, diachi, sdt, gioitinh, luong, ngayvaolam);
            int result = DataProvider.Instance.executeNonQuery(query);
            return result > 0;
        }

        public void XoaNV(string manv)
        {
            DataProvider.Instance.executeQuery("delete from NHANVIEN where MANV="+manv);
        }
    }
}
