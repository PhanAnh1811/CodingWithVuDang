using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PhanSo
    {
        private int Tuso;
        private int Mauso;
        
        //Properties
        public int TuSo
        {
            get { return Tuso; }
            set { Tuso = value; }
        }
        public int MauSo
        {
            get { return Mauso; }
            set { Mauso = value; }
        }

        //Constructor
        public PhanSo() { }
        //Parameter
        public PhanSo(int Tuso,int Mauso)
        {
            TuSo = Tuso;
            MauSo = Mauso;
        }
        //Coppy Contrustor
        public PhanSo(PhanSo phanso)
        {
            TuSo = phanso.TuSo;
            MauSo = phanso.MauSo;
        }
        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        public void Input()
        {
            Console.Write("Nhap tu so: ");
            Tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            Mauso = int.Parse(Console.ReadLine());
        }
        public string Output()
        {
            
            return TuSo + " / " + MauSo;
        }

        public double GiaTriThapPhan()
        {
            return Tuso * 1.0 / MauSo;
        }
        public void RutGon(PhanSo ps)
        {
            int ucln = GCD(ps.TuSo, ps.MauSo);
            ps.TuSo = ps.TuSo / ucln;
            ps.MauSo = ps.MauSo / ucln;
        }
        public PhanSo CongPs(PhanSo p)
        {
            PhanSo res = new PhanSo();
            res.TuSo = TuSo * p.MauSo + p.TuSo * MauSo;
            res.MauSo = MauSo * p.MauSo;
            RutGon(res);
            return res;
        }
        public PhanSo TruPs(PhanSo p)
        {
            PhanSo res = new PhanSo();
            res.TuSo = TuSo * p.MauSo - p.TuSo * MauSo;
            res.MauSo = MauSo * p.MauSo;
            RutGon(res);
            return res;
        }
        public PhanSo NhanPs(PhanSo p)
        {
            PhanSo res = new PhanSo();
            res.TuSo = TuSo * p.TuSo;
            res.MauSo = MauSo * p.MauSo;
            RutGon(res);
            return res;
        }
        public PhanSo ChiaPs(PhanSo p)
        {
            PhanSo res = new PhanSo();
            res.Tuso = Tuso * p.Tuso + Mauso * p.Mauso;
            res.Mauso = Mauso * p.Mauso;
            RutGon(res);
            return res;
        }

    }
}
