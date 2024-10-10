class SoPhuc
{
    float PhanAo,PhanThuc;
    public SoPhuc(float PhanAo,float PhanThuc)
    {
        this.PhanAo=PhanAo;
        this.PhanThuc=PhanThuc;
    }
    public SoPhuc(){
        PhanAo=0;
        PhanThuc=0;
    }
    public void Nhap()
    {
        Console.Write("phan ao = ");
        PhanAo = float.Parse(Console.ReadLine());
        Console.Write("phan thuc = ");
        PhanThuc=float.Parse(Console.ReadLine());
    }
    public SoPhuc Cong(SoPhuc sp)
    {
        SoPhuc kq = new SoPhuc();
        kq.PhanAo=PhanAo + sp.PhanAo;
        kq.PhanThuc=PhanThuc + sp.PhanThuc;
        return kq;
    }
    public SoPhuc Tru(SoPhuc sp)
    {
        SoPhuc kq = new SoPhuc();
        kq.PhanAo=PhanAo - sp.PhanAo;
        kq.PhanThuc=PhanThuc - sp.PhanThuc;
        return kq;
    }
    public SoPhuc Nhan(SoPhuc sp)
    {
        SoPhuc kq = new SoPhuc();
        kq.PhanAo=(PhanAo * sp.PhanAo) - (PhanThuc * sp.PhanThuc);
        kq.PhanThuc= (PhanAo * sp.PhanThuc) + (PhanThuc * sp.PhanAo);
        return kq;
    }
    public SoPhuc Chia(SoPhuc sp)
    {
        SoPhuc kq = new SoPhuc();
        kq.PhanAo= ((PhanAo * sp.PhanAo) + (PhanThuc * sp.PhanThuc)) / ((sp.PhanAo * sp.PhanAo) + (sp.PhanThuc * sp.PhanThuc));
        kq.PhanThuc=((PhanAo * sp.PhanAo) - (PhanThuc * sp.PhanThuc)) / ((sp.PhanAo * sp.PhanAo) + (sp.PhanThuc * sp.PhanThuc));
        return kq;
    }
    public void Xuat()
    {
        Console.WriteLine("ket qua = {0} + {1}i",PhanAo,PhanThuc);
    }

}
class Program
{
    static void Main(string[] args)
    {
        SoPhuc spA = new SoPhuc();
        spA.Nhap();
        SoPhuc spB = new SoPhuc();
        spB.Nhap();

        SoPhuc cong = spA.Cong(spB);
        SoPhuc tru = spA.Tru(spB);
        SoPhuc nhan = spA.Nhan(spB);
        SoPhuc chia = spA.Chia(spB);
        cong.Xuat();
        tru.Xuat();
        nhan.Xuat();
        chia.Xuat();
    }
}