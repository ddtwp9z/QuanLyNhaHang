using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang.DTO
{
    public class NhanvienDTO
    {
        public NhanvienDTO(string manv,string tennv, string gioitinh,string diachi, string sdt, string chucvu, DateTime ngaysinh, DateTime ngayvaolam, int luong)
        {
            MaNV = manv;
            TenNV = tennv;
            GioiTinh = gioitinh;
            DiaChi = diachi;
            SDT = sdt;
            ChucVu = chucvu;
            NgaySinh = ngaysinh;
            NgayVaoLam = ngayvaolam;
            Luong = luong;
        }

        public NhanvienDTO(DataRow row)
        {
            MaNV = row["MANV"].ToString();
            TenNV = row["TENNV"].ToString();
            NgaySinh = (DateTime)row["NGAYSINH"];
            GioiTinh = row["GIOITINH"].ToString();
            DiaChi= row["DIACHI"].ToString();
            SDT = row["SDT"].ToString();
            NgayVaoLam = (DateTime)row["NGAYVAOLAM"] ;
            ChucVu = row["CHUCVU"].ToString();
            Luong = (int)row["TENNV"];
        }
        private string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        private string tennv;
        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }
        private DateTime ngaysinh;
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string gioitinh;
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private DateTime ngayvaolam;
        public DateTime NgayVaoLam
        {
            get { return ngayvaolam; }
            set { ngayvaolam = value; }
        }
        private int luong;
        public int Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        private string chucvu;
        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
    }
}
