using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using Microsoft.SqlServer.Server;

[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.UserDefined, MaxByteSize = 800)]
public struct BrojPredracuna : INullable, IBinarySerialize
{
    private int godina;
    private int redniBroj;
    private bool _null;

    public int Godina
    {
        get
        {
            return this.godina;
        }
        set
        {
            this.godina = value;
            this._null = false;
        }
    }
    public int RedniBroj
    {
        get
        {
            return this.redniBroj;
        }
        set
        {
            this.redniBroj = value;
            this._null = false;
        }
    }

    public BrojPredracuna(int godina, int redniBroj)
    {
        this.godina = godina;
        this.redniBroj = redniBroj;
        _null = false;
    }

    public override string ToString()
    {
        if (this.IsNull)
            return null;
        else
            return godina + "/" + redniBroj;
    }

    public override bool Equals(object obj)
    {
        return this.CompareTo(obj) == 0;
    }

    public override int GetHashCode()
    {
        if (this.IsNull)
            return 0;
        return this.ToString().GetHashCode();
    }

    public bool IsNull
    {
        get
        {
            return _null;
        }
    }

    public static BrojPredracuna Null
    {
        get
        {
            BrojPredracuna bp = new BrojPredracuna();
            bp._null = true;
            return bp;
        }
    }

    public static BrojPredracuna Parse(SqlString s)
    {
        if (s.IsNull)
            return Null;
        else
        {
            BrojPredracuna bp = new BrojPredracuna();

            string str = Convert.ToString(s);
            string[] str2 = str.Split('/');

            if (Validacija(str2[0]))
                bp.godina = Convert.ToInt32(str2[0]);
            else
                bp.godina = -1;

            if (Validacija(str2[1]))
                bp.redniBroj = Convert.ToInt32(str2[1]);
            else
                bp.redniBroj = -1;

            bp._null = false;
            return bp;
        }
    }

    private static bool Validacija(string v)
    {
        if (v == null || Convert.ToInt32(v) < 0)
            return false;
        return true;
    }

    public int CompareTo(object obj)
    {
        if (obj == null)
            return 1;

        BrojPredracuna bp = (BrojPredracuna)obj;

        if (bp.Equals(null))
            throw new ArgumentException("Prosledjen objekat je null!");

        if (this.IsNull)
        {
            if (bp.IsNull)
                return 0;
            return -1;
        }

        if (bp.IsNull)
            return 1;

        return this.ToString().CompareTo(bp.ToString());
    }

    public void Write(BinaryWriter w)
    {
        byte header = (byte)(this.IsNull ? 1 : 0);

        w.Write(header);
        if (header == 1)
        {
            return;
        }

        if (!Validacija(this.Godina.ToString()))
        {
            throw new ArgumentOutOfRangeException("Godina ne moze biti negativna!");
        }
        w.Write(this.Godina);

        if (!Validacija(this.RedniBroj.ToString()))
        {
            throw new ArgumentOutOfRangeException("Redni broj mora biti veci od nula!");
        }
        w.Write(this.RedniBroj);

    }

    public void Read(BinaryReader r)
    {
        byte header = r.ReadByte();

        if (header == 1)
        {
            this._null = true;
            return;
        }

        this._null = false;

        int godina = r.ReadInt32();
        if (!Validacija(godina.ToString()))
        {
            throw new ArgumentOutOfRangeException("Godina ne moze biti negativna!");
        }
        this.Godina = godina;

        int redniBroj = r.ReadInt32();
        if (!Validacija(redniBroj.ToString()))
        {
            throw new ArgumentOutOfRangeException("Redni broj mora biti veci od nule!");
        }
        this.RedniBroj = redniBroj;
    }

}

