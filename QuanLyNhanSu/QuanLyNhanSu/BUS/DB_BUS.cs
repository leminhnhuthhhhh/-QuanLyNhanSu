using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.DAL;
namespace QuanLyNhanSu.BUS
{
    class DB_BUS
    {
        DB_QLNSDataContext qlns = new DB_QLNSDataContext();
        // kiem tra
        // them 
        // xoa 
        // sua

        #region rgPhongBan
        public List<tblPHONGBAN> layDSPhongBan()
        {
            var danhSach = from pb in qlns.tblPHONGBANs select pb;
            return danhSach.ToList();
        }
        public void themPhongBan(String tenPB, String ghiChu)
        {
            // Tạo đối tượng
            tblPHONGBAN pb = new tblPHONGBAN();
            pb.TenPhong = tenPB;
            pb.GhiChu = ghiChu;
            // Thêm và cập nhật
            qlns.tblPHONGBANs.InsertOnSubmit(pb);
            qlns.SubmitChanges();
        }
        public void xoaPhongBan(int maPB)
        {
            tblPHONGBAN pb = qlns.tblPHONGBANs.Where(t => t.MaPhong.Equals(maPB.ToString())).FirstOrDefault();
            if(pb != null)
            {
                qlns.tblPHONGBANs.DeleteOnSubmit(pb);
                qlns.SubmitChanges();
            }
        }
        public void capnhatPhongBan(int maPB, String tenPB, String ghiChu)
        {
            tblPHONGBAN pb = qlns.tblPHONGBANs.Where(t => t.MaPhong.Equals(maPB.ToString())).FirstOrDefault();
            pb.TenPhong = tenPB;
            pb.GhiChu = ghiChu;
            qlns.SubmitChanges();
        }
        public bool ktKhoaNgoai_PhongBan(int maPB)
        {
            tblNHANVIEN nv = qlns.tblNHANVIENs.Where(t => t.MaPhong == maPB).FirstOrDefault();
            if (nv == null)
                return true;
            return false;
        }
        #endregion
        #region rgChucVu
        public List<tblCHUCVU> layDSChucVu()
        {
            var danhSach = from cv in qlns.tblCHUCVUs select cv;
            return danhSach.ToList();
        }
        public void themChucVu(String tenChucVu)
        {
            // Tạo đối tượng
            tblCHUCVU cv = new tblCHUCVU();
            cv.TenChucVu = tenChucVu;
            // Thêm và cập nhật
            qlns.tblCHUCVUs.InsertOnSubmit(cv);
            qlns.SubmitChanges();
        }
        public void xoaChucVu(int maCV)
        {
            tblCHUCVU cv = qlns.tblCHUCVUs.Where(t => t.MaChucVu.Equals(maCV.ToString())).FirstOrDefault();
            if (cv != null)
            {
                qlns.tblCHUCVUs.DeleteOnSubmit(cv);
                qlns.SubmitChanges();
            }
        }
        public void capnhatChucVu(int maCV, String tenCV)
        {
            tblCHUCVU cv = qlns.tblCHUCVUs.Where(t => t.MaChucVu.Equals(maCV.ToString())).FirstOrDefault();
            cv.TenChucVu = tenCV;
            qlns.SubmitChanges();
        }
        public bool ktKhoaNgoai_CTChucVu(int maCV)
        {
            tblCHITIETCHUCVU ctCV = qlns.tblCHITIETCHUCVUs.Where(t => t.MaChucVu == maCV).FirstOrDefault();
            if (ctCV == null)
                return true;
            return false;
        }
        //public bool ktKhoaNgoai_HopDong(int maCV)
        //{
        //    tblHOPDONG hd = qlns.tblHOPDONGs.Where(t => t.MaChucVu == maCV).FirstOrDefault();
        //    if (hd == null)
        //        return true;
        //    return false;
        //}

        #endregion
        #region rgHopDong
        public IEnumerable<Object> layDSHopDong()
        {
            var danhSach = from hd in qlns.tblHOPDONGs
                           select new { hd.MaHopDong, hd.LoaiHopDong, hd.ThoiHanHopDong};
            return danhSach;
        }
        public IEnumerable<Object> layCbHopDong()
        {
            var danhSach = from hd in qlns.tblHOPDONGs
                           select new { hd.MaHopDong, hd.LoaiHopDong };
            return danhSach;
        }
        public void themHopDong(String loaiHD, int thoihanHD)
        {
            // Tạo đối tượng
            tblHOPDONG hd = new tblHOPDONG();
            hd.LoaiHopDong = loaiHD;
            hd.ThoiHanHopDong = thoihanHD;
            // Thêm và cập nhật
            qlns.tblHOPDONGs.InsertOnSubmit(hd);
            qlns.SubmitChanges();
        }
        public void xoaHopDong(int maHD)
        {
            tblHOPDONG hd = qlns.tblHOPDONGs.Where(t => t.MaHopDong.Equals(maHD.ToString())).FirstOrDefault();
            if (hd != null)
            {
                qlns.tblHOPDONGs.DeleteOnSubmit(hd);
                qlns.SubmitChanges();
            }
        }
        public void capnhatHopDong(int maHD, String loaiHD, int thoihanHD)
        {
            tblHOPDONG hd = qlns.tblHOPDONGs.Where(t => t.MaHopDong.Equals(maHD.ToString())).FirstOrDefault();
            hd.LoaiHopDong = loaiHD;
            hd.ThoiHanHopDong = thoihanHD;
            qlns.SubmitChanges();
        }
        public bool ktKhoaNgoai_NhanVien_HD(int maHD)
        {
            tblNHANVIEN hd = qlns.tblNHANVIENs.Where(t => t.MaHopDong == maHD).FirstOrDefault();
            if (hd == null)
                return true;
            return false;
        }
        #endregion
        #region rgNhanVien
        public IEnumerable<Object> layDSNhanVien()
        {
            var danhSach = from nv in qlns.tblNHANVIENs
                           join hd in qlns.tblHOPDONGs on nv.MaHopDong equals hd.MaHopDong
                           join pb in qlns.tblPHONGBANs on nv.MaPhong equals pb.MaPhong
                           select new { nv.MaNhanVien, nv.TenNhanVien, nv.NgaySinh, nv.DiaChi, nv.GioiTinh,
                           nv.SDT, nv.Email, nv.CMND, nv.DanToc, nv.TrinhDoHocVan, nv.TrinhTrangHonNhan,
                           nv.NgayVaoLam, nv.HeSoLuong, nv.Anh, hd.LoaiHopDong, pb.TenPhong};
            return danhSach;
        }

        public IEnumerable<Object> timKiemTheoTen(String ten)
        {
            var danhSach = from nv in qlns.tblNHANVIENs
                           join hd in qlns.tblHOPDONGs on nv.MaHopDong equals hd.MaHopDong
                           join pb in qlns.tblPHONGBANs on nv.MaPhong equals pb.MaPhong
                           where nv.TenNhanVien.Contains(ten)
                           select new
                           {
                               nv.MaNhanVien,
                               nv.TenNhanVien,
                               nv.NgaySinh,
                               nv.DiaChi,
                               nv.GioiTinh,
                               nv.SDT,
                               nv.Email,
                               nv.CMND,
                               nv.DanToc,
                               nv.TrinhDoHocVan,
                               nv.TrinhTrangHonNhan,
                               nv.NgayVaoLam,
                               nv.HeSoLuong,
                               nv.Anh,
                               hd.LoaiHopDong,
                               pb.TenPhong
                           };
            return danhSach;
        }

        public tblNHANVIEN timNVTheoMa(int ma)
        {
            tblNHANVIEN nv = qlns.tblNHANVIENs.Where(t => t.MaNhanVien == ma).FirstOrDefault();
            return nv;
        }
        public IEnumerable<Object> layDSMaNV()
        {
            var ds = from nv in qlns.tblNHANVIENs select new { nv.MaNhanVien, nv.TenNhanVien};
            return ds.ToList();
        }
        public void themNhanVien(String tenNV, DateTime ngSinh, String diaChi, String gTinh, String sdt, String email, String CMND,
            String danToc, String tdHV, String ttHN, DateTime ngayVL, float heSL, String anh, int maHopDong, int maPB)
        {
            // Tạo đối tượng
            tblNHANVIEN nv = new tblNHANVIEN();
            nv.TenNhanVien = tenNV;
            nv.NgaySinh = ngSinh;
            nv.DiaChi = diaChi;
            nv.GioiTinh = gTinh;
            nv.SDT = sdt;
            nv.Email = email;
            nv.CMND = CMND;
            nv.DanToc = danToc;
            nv.TrinhDoHocVan = tdHV;
            nv.TrinhTrangHonNhan = ttHN;
            nv.NgayVaoLam = ngayVL;
            nv.HeSoLuong = heSL;
            nv.Anh = anh;
            nv.MaHopDong = maHopDong;
            nv.MaPhong = maPB;
            // Thêm và cập nhật
            qlns.tblNHANVIENs.InsertOnSubmit(nv);
            qlns.SubmitChanges();
        }
        public void xoaNhanVien(int maNV)
        {
            tblNHANVIEN nv = qlns.tblNHANVIENs.Where(t => t.MaNhanVien.Equals(maNV.ToString())).FirstOrDefault();
            if (nv != null)
            {
                qlns.tblNHANVIENs.DeleteOnSubmit(nv);
                qlns.SubmitChanges();
            }
        }
        public void capnhatNhanVien(int maNV, String tenNV, DateTime ngSinh, String diaChi, String gTinh, String sdt, String email, String CMND,
            String danToc, String tdHV, String ttHN, DateTime ngayVL, float heSL, String anh, int maHopDong, int maPB)
        {
            tblNHANVIEN nv = qlns.tblNHANVIENs.Where(t => t.MaNhanVien.Equals(maNV.ToString())).FirstOrDefault();
            nv.TenNhanVien = tenNV;
            nv.NgaySinh = ngSinh;
            nv.DiaChi = diaChi;
            nv.GioiTinh = gTinh;
            nv.SDT = sdt;
            nv.Email = email;
            nv.CMND = CMND;
            nv.DanToc = danToc;
            nv.TrinhDoHocVan = tdHV;
            nv.TrinhTrangHonNhan = ttHN;
            nv.NgayVaoLam = ngayVL;
            nv.HeSoLuong = heSL;
            nv.Anh = anh;
            nv.MaHopDong = maHopDong;
            nv.MaPhong = maPB;
            // cap nhhat
            qlns.SubmitChanges();
        }
        public bool ktKhoaNgoai_NhanVien_TaiKhoan(int maNV)
        {
            tblTAIKHOAN tk = qlns.tblTAIKHOANs.Where(t => t.MaNhanVien == maNV).FirstOrDefault();
            if (tk == null)
                return true;
            return false;
        }

        public bool ktKhoaNgoai_NhanVien_BaoHiem(int maNV)
        {
            tblBAOHIEM bh = qlns.tblBAOHIEMs.Where(t => t.MaNhanVien == maNV).FirstOrDefault();
            if (bh == null)
                return true;
            return false;
        }

        public bool ktKhoaNgoai_NhanVien_Luong(int maNV)
        {
            tblLUONG l = qlns.tblLUONGs.Where(t => t.MaNhanVien == maNV).FirstOrDefault();
            if (l == null)
                return true;
            return false;
        }

        public bool ktKhoaNgoai_NhanVien_CTCV(int maNV)
        {
            tblCHITIETCHUCVU ctcv = qlns.tblCHITIETCHUCVUs.Where(t => t.MaNhanVien == maNV).FirstOrDefault();
            if (ctcv == null)
                return true;
            return false;
        }

        public bool ktKhoaNgoai_NhanVien_KTKL(int maNV)
        {
            tblKHENTHUONGKYLUAT ktkl = qlns.tblKHENTHUONGKYLUATs.Where(t => t.MaNhanVien == maNV).FirstOrDefault();
            if (ktkl == null)
                return true;
            return false;
        }
        public bool ktKhoaNgoai_NhanVien_ChamCong(int maNV)
        {
            tblCHAMCONG cc = qlns.tblCHAMCONGs.Where(t => t.MaNhanVien == maNV).FirstOrDefault();
            if (cc == null)
                return true;
            return false;
        }


        #endregion
        #region rgTaiKhoan
        public IEnumerable<Object> layDSTaiKhoan_NV()
        {
            var danhSach = from tk in qlns.tblTAIKHOANs
                           join nv in qlns.tblNHANVIENs
                           on tk.MaNhanVien equals nv.MaNhanVien
                           select new { nv.MaNhanVien, nv.TenNhanVien, tk.TaiKhoan, tk.MatKhau, tk.Quyen };
            return danhSach;
        }
        public IEnumerable<Object> layDSNV_ChuaCoTaiKhoan()
        {
            var dsnvcotk = from tk in qlns.tblTAIKHOANs
                           select new { tk.MaNhanVien};
            var dsnv = from nv in qlns.tblNHANVIENs
                           select new { nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.SDT };
            var result = dsnv.Where(p => dsnvcotk.All(x => x.MaNhanVien != p.MaNhanVien));
            return result.ToList();
        }
      
        public void themTaiKhoan(String taikhoan,String matkhau, String quyen, int manv )
        {
            // Tạo đối tượng
            tblTAIKHOAN tk = new tblTAIKHOAN();
            tk.TaiKhoan = taikhoan;
            tk.MatKhau = matkhau;
            tk.Quyen = quyen;
            tk.MaNhanVien = manv;
            // Thêm và cập nhật
            qlns.tblTAIKHOANs.InsertOnSubmit(tk);
            qlns.SubmitChanges();
        }
        public void xoaTaiKhoan(String taiKhoan)
        {
            tblTAIKHOAN tk = qlns.tblTAIKHOANs.Where(t => t.TaiKhoan.Equals(taiKhoan)).FirstOrDefault();
            if (tk != null)
            {
                qlns.tblTAIKHOANs.DeleteOnSubmit(tk);
                qlns.SubmitChanges();
            }
        }
        public void capnhatTaiKhoan(int maHD, String loaiHD, int thoihanHD)
        {
            tblHOPDONG hd = qlns.tblHOPDONGs.Where(t => t.MaHopDong.Equals(maHD.ToString())).FirstOrDefault();
            hd.LoaiHopDong = loaiHD;
            hd.ThoiHanHopDong = thoihanHD;
            qlns.SubmitChanges();
        }

        #endregion
        #region rgBaoHiem
        public IEnumerable<Object> layDSNV_BH()
        {
            var danhSach = from nv in qlns.tblNHANVIENs select new { nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi};
            return danhSach.ToList();
        }
        public IEnumerable<Object> layDSBH()
        {
            var danhSach = from bh in qlns.tblBAOHIEMs
                           join nv in qlns.tblNHANVIENs
                           on bh.MaNhanVien equals nv.MaNhanVien
                           select new { nv.MaNhanVien, nv.TenNhanVien, bh.LoaiBaoHiem, bh.SoThe, bh.NgayCap, bh.NgayHetHan, bh.NoiCap };
            return danhSach.ToList();
        }
        public void themBaoHiem(int maNV, String loaiBH, String sothe, DateTime ngaycap, DateTime ngayhh, String noiCap)
        {
            // Tạo đối tượng
            tblBAOHIEM bh = new tblBAOHIEM();
            bh.MaNhanVien = maNV;
            bh.LoaiBaoHiem = loaiBH;
            bh.SoThe = sothe;
            bh.NgayCap = ngaycap;
            bh.NgayHetHan = ngayhh;
            bh.NoiCap = noiCap;
            // Thêm và cập nhật
            qlns.tblBAOHIEMs.InsertOnSubmit(bh);
            qlns.SubmitChanges();
        }
        public void xoaBaoHiem(int maNV, String LoaiBH)
        {
            tblBAOHIEM bh = qlns.tblBAOHIEMs.Where(t => t.MaNhanVien.Equals(maNV.ToString()) && t.LoaiBaoHiem.Equals(LoaiBH)).FirstOrDefault();
            if (bh != null)
            {
                qlns.tblBAOHIEMs.DeleteOnSubmit(bh);
                qlns.SubmitChanges();
            }
        }
        public void capnhatBaoHiem(int maNV, String loaiBH, String sothe, DateTime ngaycap, DateTime ngayhh, String noiCap)
        {
            tblBAOHIEM bh = qlns.tblBAOHIEMs.Where(t => t.MaNhanVien.Equals(maNV.ToString()) && t.LoaiBaoHiem.Equals(loaiBH)).FirstOrDefault();
            if(bh != null)
            {
                bh.SoThe = sothe;
                bh.NgayCap = ngaycap;
                bh.NgayHetHan = ngayhh;
                bh.NoiCap = noiCap;
                qlns.SubmitChanges();
            }
         
         
            
        }

        public bool ktKhoaChinh_BaoHiem(int maNV, String loaibh)
        {
            tblBAOHIEM bh = qlns.tblBAOHIEMs.Where(t => t.MaNhanVien == maNV && t.LoaiBaoHiem.Equals(loaibh)).FirstOrDefault();
            if (bh == null)
                return true;
            return false;
        }


        #endregion
        #region rgKhenThuongKyLuat
        public IEnumerable<Object> layDSKTKL()
        {
            var danhSach = from ktkl in qlns.tblKHENTHUONGKYLUATs
                           join nv in qlns.tblNHANVIENs
                           on ktkl.MaNhanVien equals nv.MaNhanVien
                           select new { ktkl.MaKTKL, nv.MaNhanVien, nv.TenNhanVien, ktkl.NgayLap, ktkl.Loai, ktkl.GhiChu, ktkl.Tien, ktkl.TrinhTrang };
            return danhSach;
        }

        public void themKTKL(int maNV, DateTime ngLap, String loai, String ghiChu, decimal tien, String trinhTrang)
        {
            // Tạo đối tượng
            tblKHENTHUONGKYLUAT ktkl = new tblKHENTHUONGKYLUAT();
            ktkl.MaNhanVien = maNV;
            ktkl.NgayLap = ngLap;
            ktkl.Loai = loai;
            ktkl.GhiChu = ghiChu;
            ktkl.Tien = tien;
            ktkl.TrinhTrang = trinhTrang;
            // Thêm và cập nhật
            qlns.tblKHENTHUONGKYLUATs.InsertOnSubmit(ktkl);
            qlns.SubmitChanges();
        }
        public void xoaKTKL(int maKTKL)
        {
            tblKHENTHUONGKYLUAT ktkl = qlns.tblKHENTHUONGKYLUATs.Where(t => t.MaKTKL.Equals(maKTKL.ToString())).FirstOrDefault();
            if (ktkl != null)
            {
                qlns.tblKHENTHUONGKYLUATs.DeleteOnSubmit(ktkl);
                qlns.SubmitChanges();
            }
        }
        public void capnhatKTKL(int maKTKL, int maNV, DateTime ngLap, String loai, String ghiChu, decimal tien, String trinhTrang)
        {
            tblKHENTHUONGKYLUAT ktkl = qlns.tblKHENTHUONGKYLUATs.Where(t => t.MaKTKL.Equals(maKTKL.ToString())).FirstOrDefault();
            ktkl.MaNhanVien = maNV;
            ktkl.NgayLap = ngLap;
            ktkl.Loai = loai;
            ktkl.GhiChu = ghiChu;
            ktkl.Tien = tien;
            ktkl.TrinhTrang = trinhTrang;
            qlns.SubmitChanges();
        }

        #endregion

        #region rgChamCong
        public IEnumerable<Object> layDSCC()
        {
            DateTime a = DateTime.Now.Date;
            var check = from cc in qlns.tblCHAMCONGs where cc.NgayCham == a select cc;
            if (check.Count() <= 0)
            {
                var danhSach = from nv in qlns.tblNHANVIENs
                               select new { nv.MaNhanVien, nv.TenNhanVien };
                return danhSach;
            }
           
            var lst = from nv in qlns.tblNHANVIENs
                      join cc in qlns.tblCHAMCONGs
                      on nv.MaNhanVien equals cc.MaNhanVien
                      where cc.NgayCham == a
                      select new { nv.MaNhanVien, nv.TenNhanVien, cc.TrinhTrang };
            return lst;
        }

        public void themChamCong(int maNV, String trinhTrang)
        {


            // Tạo đối tượng
            tblCHAMCONG ccong = new tblCHAMCONG();
            ccong.MaNhanVien = maNV;
            ccong.NgayCham = DateTime.Now;
            ccong.TrinhTrang = trinhTrang;
            // Thêm và cập nhật
            qlns.tblCHAMCONGs.InsertOnSubmit(ccong);
            qlns.SubmitChanges();
        }
        public void xoaChamCong(int maNV, DateTime ngayCham)
        {
            DateTime a = DateTime.Now.Date;
            tblCHAMCONG cc = qlns.tblCHAMCONGs.Where(t => t.MaNhanVien.Equals(maNV.ToString()) && t.NgayCham == a).FirstOrDefault();
            if (cc != null)
            {
                qlns.tblCHAMCONGs.DeleteOnSubmit(cc);
                qlns.SubmitChanges();
            }
        }
        public void capnhatChamCong(int maKTKL, int maNV, DateTime ngLap, String loai, String ghiChu, decimal tien, String trinhTrang)
        {
            tblKHENTHUONGKYLUAT ktkl = qlns.tblKHENTHUONGKYLUATs.Where(t => t.MaKTKL.Equals(maKTKL.ToString())).FirstOrDefault();
            ktkl.MaNhanVien = maNV;
            ktkl.NgayLap = ngLap;
            ktkl.Loai = loai;
            ktkl.GhiChu = ghiChu;
            ktkl.Tien = tien;
            ktkl.TrinhTrang = trinhTrang;
            qlns.SubmitChanges();
        }


        public bool ktKhoaChinh_ChamCong()
        {
            DateTime a = DateTime.Now.Date;
            var check = from cc in qlns.tblCHAMCONGs where cc.NgayCham == a select cc;
            if (check.Count() <= 0)
            {
                return true;
            }
            return false;
        }



        #endregion


        #region rgBangLuong

        public bool kiemTraLapBangLuong()
        {
            int a = DateTime.Now.Month;
            int b = DateTime.Now.Year;
            var check = from cc in qlns.tblLUONGs
                        where cc.NgayLap.Value.Month == a && cc.NgayLap.Value.Year == b
                        select cc;
            if (check.Count() <= 0)
            {
                return true;
            }
            return false;

        }
        public IEnumerable<Object> layDSBL()
        {
            int a = DateTime.Now.Month;
            int b = DateTime.Now.Year;
            var check = from cc in qlns.tblLUONGs
                        where cc.NgayLap.Value.Month == a && cc.NgayLap.Value.Year == b
                        select cc;
            if(check.Count() <= 0)
            {
                var danhSach = from nv in qlns.tblNHANVIENs
                               join ctcv in qlns.tblCHITIETCHUCVUs
                               on nv.MaNhanVien equals ctcv.MaNhanVien
                               select new { nv.MaNhanVien, nv.TenNhanVien, ctcv.LuongCoBan, nv.HeSoLuong, ctcv.PhuCapChucVu };
                return danhSach;
            }
            var ds = from nv in qlns.tblNHANVIENs
                     join ctcv in qlns.tblCHITIETCHUCVUs on nv.MaNhanVien equals ctcv.MaNhanVien
                     join l in qlns.tblLUONGs on nv.MaNhanVien equals l.MaNhanVien
                     select new { nv.MaNhanVien, nv.TenNhanVien, ctcv.LuongCoBan, nv.HeSoLuong, ctcv.PhuCapChucVu, l.NgayLap };
            return ds;
           
        }

        public IEnumerable<Object> layDSBL_LuaChon(int a, int b)
        {
            var ds = from nv in qlns.tblNHANVIENs
                     join ctcv in qlns.tblCHITIETCHUCVUs on nv.MaNhanVien equals ctcv.MaNhanVien
                     join l in qlns.tblLUONGs on nv.MaNhanVien equals l.MaNhanVien
                     where l.NgayLap.Value.Month == a && l.NgayLap.Value.Year == b
                     select new { nv.MaNhanVien, nv.TenNhanVien, ctcv.LuongCoBan, nv.HeSoLuong, ctcv.PhuCapChucVu, l.NgayLap };
            return ds.ToList();

        }
        public int tinhSoNgayLam(int maNV, int thang, int nam)
        {
            var ds = from cc in qlns.tblCHAMCONGs
                     where cc.MaNhanVien == maNV && cc.NgayCham.Month == thang && cc.NgayCham.Year == nam && !cc.TrinhTrang.Equals("Vắng Mặt")
                     select cc;
            return ds.Count();
        }
        public float tinhTienThuong(int maNV, int thang, int nam)
        {
            float tien = 0f;
            var ds = from tt in qlns.tblKHENTHUONGKYLUATs
                     where tt.MaNhanVien == maNV && tt.NgayLap.Value.Month == thang && tt.NgayLap.Value.Year == nam && tt.Loai.Equals("Khen Thưởng")
                     select tt;
            foreach (var item in ds)
            {
                tien += float.Parse(item.Tien.ToString());
            }
            return tien;
        }
     
        public float tinhTienPhat(int maNV, int thang, int nam)
        {
            float tien = 0f;
            var ds = from tt in qlns.tblKHENTHUONGKYLUATs
                     where tt.MaNhanVien == maNV && tt.NgayLap.Value.Month == thang && tt.NgayLap.Value.Year == nam && tt.Loai.Equals("Kỷ Luật")
                     select tt;
            foreach (var item in ds)
            {
                tien += float.Parse(item.Tien.ToString());
            }
            return tien;
        }
        public float tongTien(float luongCB, float heSoLuong, float phuCap, int soNgayLam, float tienThuong, float tienPhat)
        {
            return ((((luongCB * heSoLuong) + (phuCap * luongCB)) / 26) * soNgayLam) + tienThuong - tienPhat;
        }
        public void themLuong(int maNV, float tienLuong, int maNVLap)
        {
            // Tạo đối tượng
            tblLUONG l = new tblLUONG();
            l.MaNhanVien = maNV;
            l.TienLuong = decimal.Parse(tienLuong.ToString());
            l.NgayLap = DateTime.Now;
            l.MaNhanVienLap = maNVLap;
            // Thêm và cập nhật
            qlns.tblLUONGs.InsertOnSubmit(l);
            qlns.SubmitChanges();
        }
       
        #endregion

        #region rgTaiKhoan
        public tblTAIKHOAN check_TaiKhoan(String tk, String mk)
        {
            tblTAIKHOAN taiKhoan = qlns.tblTAIKHOANs.Where(t => t.TaiKhoan.Equals(tk) && t.MatKhau.Equals(mk)).FirstOrDefault();
            if(taiKhoan == null)
            {
                return null;
            }
            return taiKhoan;
        }
        public bool ktKhoaChinh_TaiKhoan(String tk)
        {
            tblTAIKHOAN taiKhoan = qlns.tblTAIKHOANs.Where(t => t.TaiKhoan.Equals(tk)).FirstOrDefault();
            if (taiKhoan == null)
            {
                return true;
            }
            return false;
        }

        public void doiMatKhau(String tkhoan, String mk)
        {
            tblTAIKHOAN tk = qlns.tblTAIKHOANs.Where(t => t.TaiKhoan.Equals(tkhoan)).FirstOrDefault();
            if(tk != null)
            {
                tk.MatKhau = mk;
                qlns.SubmitChanges();
            }
        }
      

        #endregion

        #region rgCTCV

        public IEnumerable<Object> layDSNV_ChuaCoCT()
        {
            var dsnvcoctcv = from ct in qlns.tblCHITIETCHUCVUs select new { ct.MaNhanVien };
            var dsnv = from nv in qlns.tblNHANVIENs
                       select new { nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.SDT };
            var result = dsnv.Where(p => dsnvcoctcv.All(x => x.MaNhanVien != p.MaNhanVien));
            return result.ToList();
        }
        public IEnumerable<Object> layDS_CT_ChucVu()
        {
            var ds = from nv in qlns.tblNHANVIENs
                     join ct in qlns.tblCHITIETCHUCVUs
                     on nv.MaNhanVien equals ct.MaNhanVien
                     select new { nv.MaNhanVien, nv.TenNhanVien, ct.MaChucVu, ct.LuongCoBan, ct.PhuCapChucVu, ct.NgayBatDau, ct.NgayKetThuc };
            return ds.ToList();
        }

        public void themCT(int maNv, int maCV, float LCB, float PC, DateTime nbd, DateTime nkt)
        {
            // Tạo đối tượng
            tblCHITIETCHUCVU ct = new tblCHITIETCHUCVU();
            ct.MaNhanVien = maNv;
            ct.MaChucVu = maCV;
            ct.LuongCoBan = decimal.Parse(LCB.ToString());
            ct.PhuCapChucVu = PC;
            ct.NgayBatDau = nbd;
            ct.NgayKetThuc = nkt;
            // Thêm và cập nhật
            qlns.tblCHITIETCHUCVUs.InsertOnSubmit(ct);
            qlns.SubmitChanges();
        }
        public void xoaCTChucVu(int maNV, int maCV)
        {
            tblCHITIETCHUCVU ct = qlns.tblCHITIETCHUCVUs.Where(t => t.MaChucVu.Equals(maCV.ToString()) && t.MaNhanVien.Equals(maNV.ToString())).FirstOrDefault();
            if (ct != null)
            {
                qlns.tblCHITIETCHUCVUs.DeleteOnSubmit(ct);
                qlns.SubmitChanges();
            }
        }
        public void capnhatCTChucVu(int maNv, int maCV, float LCB, float PC, DateTime nbd, DateTime nkt)
        {
            tblCHITIETCHUCVU ct = qlns.tblCHITIETCHUCVUs.Where(t => t.MaChucVu.Equals(maCV.ToString()) && t.MaNhanVien.Equals(maNv.ToString())).FirstOrDefault();
            ct.LuongCoBan = decimal.Parse(LCB.ToString());
            ct.PhuCapChucVu = PC;
            ct.NgayBatDau = nbd;
            ct.NgayKetThuc = nkt;
            qlns.SubmitChanges();
        }
        public bool ktKhoaChinh_CTCV(int maNv, int maCV)
        {
            tblCHITIETCHUCVU ct = qlns.tblCHITIETCHUCVUs.Where(t => t.MaChucVu.Equals(maCV.ToString()) && t.MaNhanVien.Equals(maNv.ToString())).FirstOrDefault();
            if (ct == null)
                return true;
            return false;
        }


        //public bool ktKhoaNgoai_CTChucVu(int maCV)
        //{
        //    tblCHITIETCHUCVU ctCV = qlns.tblCHITIETCHUCVUs.Where(t => t.MaChucVu == maCV).FirstOrDefault();
        //    if (ctCV == null)
        //        return true;
        //    return false;
        //}
        //public bool ktKhoaNgoai_HopDong(int maCV)
        //{
        //    tblHOPDONG hd = qlns.tblHOPDONGs.Where(t => t.MaChucVu == maCV).FirstOrDefault();
        //    if (hd == null)
        //        return true;
        //    return false;
        //}

        #endregion
    }
}
