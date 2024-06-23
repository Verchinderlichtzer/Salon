namespace Salon.Shared.Extensions;

public enum JenisKelamin : byte
{
    None,
    [Description("Laki-laki")] Pria,
    [Description("Perempuan")] Wanita
}

public enum JenisUser : byte
{
    Admin,
    Karyawan
}
