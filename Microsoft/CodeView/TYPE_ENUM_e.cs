﻿
namespace PdbReader.Microsoft.CodeView
{
    /// <summary>selected values for type_index - for a more complete definition, see
    /// Microsoft Symbol and Type OMF document
    /// Special Types</summary>
    internal enum TYPE_ENUM_e
    {
        NoType = 0x0000,   // uncharacterized type (no type)
        AbsoluteSymbol = 0x0001,   // absolute symbol
        Segment = 0x0002,   // segment type
        Void = 0x0003,   // void
        HResult = 0x0008,   // OLE/COM HRESULT
        T_32PHRESULT = 0x0408,   // OLE/COM HRESULT __ptr32 *
        T_64PHRESULT = 0x0608,   // OLE/COM HRESULT __ptr64 *

        NearVoidPointer = 0x0103,   // near pointer to void
        FarVoidPointer = 0x0203,   // far pointer to void
        HugeVoidPointer = 0x0303,   // huge pointer to void
        _32BitsVoidPointer = 0x0403,   // 32 bit pointer to void
        _32BitsFarVoidPointer = 0x0503,   // 16:32 pointer to void
        _64BitsVoidPointer = 0x0603,   // 64 bit pointer to void
        Currency = 0x0004,   // BASIC 8 byte currency value
        NearBASICString = 0x0005,   // Near BASIC string
        FarBASICString = 0x0006,   // Far BASIC string
        NotTranslated = 0x0007,   // type not translated by cvpack
        Bit = 0x0060,   // bit
        PascalCharacter = 0x0061,   // Pascal CHAR
        _32BitsBooleanTrueIsMaxValue = 0x0062,   // 32-bit BOOL where true is 0xffffffff

        //      Character types
        SignedCharacter = 0x0010,   // 8 bit signed
        T_PCHAR = 0x0110,   // 16 bit pointer to 8 bit signed
        T_PFCHAR = 0x0210,   // 16:16 far pointer to 8 bit signed
        T_PHCHAR = 0x0310,   // 16:16 huge pointer to 8 bit signed
        T_32PCHAR = 0x0410,   // 32 bit pointer to 8 bit signed
        T_32PFCHAR = 0x0510,   // 16:32 pointer to 8 bit signed
        T_64PCHAR = 0x0610,   // 64 bit pointer to 8 bit signed

        UnsignedCharacter = 0x0020,   // 8 bit unsigned
        T_PUCHAR = 0x0120,   // 16 bit pointer to 8 bit unsigned
        T_PFUCHAR = 0x0220,   // 16:16 far pointer to 8 bit unsigned
        T_PHUCHAR = 0x0320,   // 16:16 huge pointer to 8 bit unsigned
        T_32PUCHAR = 0x0420,   // 32 bit pointer to 8 bit unsigned
        T_32PFUCHAR = 0x0520,   // 16:32 pointer to 8 bit unsigned
        T_64PUCHAR = 0x0620,   // 64 bit pointer to 8 bit unsigned

        //      really a character types
        T_RCHAR = 0x0070,   // really a char
        T_PRCHAR = 0x0170,   // 16 bit pointer to a real char
        T_PFRCHAR = 0x0270,   // 16:16 far pointer to a real char
        T_PHRCHAR = 0x0370,   // 16:16 huge pointer to a real char
        T_32PRCHAR = 0x0470,   // 32 bit pointer to a real char
        T_32PFRCHAR = 0x0570,   // 16:32 pointer to a real char
        T_64PRCHAR = 0x0670,   // 64 bit pointer to a real char

        //      really a wide character types
        WideCharacter = 0x0071,   // wide char
        T_PWCHAR = 0x0171,   // 16 bit pointer to a wide char
        T_PFWCHAR = 0x0271,   // 16:16 far pointer to a wide char
        T_PHWCHAR = 0x0371,   // 16:16 huge pointer to a wide char
        T_32PWCHAR = 0x0471,   // 32 bit pointer to a wide char
        T_32PFWCHAR = 0x0571,   // 16:32 pointer to a wide char
        T_64PWCHAR = 0x0671,   // 64 bit pointer to a wide char

        //      really a 16-bit unicode char
        UnicodeCharacter = 0x007a,   // 16-bit unicode char
        T_PCHAR16 = 0x017a,   // 16 bit pointer to a 16-bit unicode char
        T_PFCHAR16 = 0x027a,   // 16:16 far pointer to a 16-bit unicode char
        T_PHCHAR16 = 0x037a,   // 16:16 huge pointer to a 16-bit unicode char
        T_32PCHAR16 = 0x047a,   // 32 bit pointer to a 16-bit unicode char
        T_32PFCHAR16 = 0x057a,   // 16:32 pointer to a 16-bit unicode char
        T_64PCHAR16 = 0x067a,   // 64 bit pointer to a 16-bit unicode char

        //      really a 32-bit unicode char
        _32BitsUnicodeCharacter = 0x007b,   // 32-bit unicode char
        T_PCHAR32 = 0x017b,   // 16 bit pointer to a 32-bit unicode char
        T_PFCHAR32 = 0x027b,   // 16:16 far pointer to a 32-bit unicode char
        T_PHCHAR32 = 0x037b,   // 16:16 huge pointer to a 32-bit unicode char
        T_32PCHAR32 = 0x047b,   // 32 bit pointer to a 32-bit unicode char
        T_32PFCHAR32 = 0x057b,   // 16:32 pointer to a 32-bit unicode char
        T_64PCHAR32 = 0x067b,   // 64 bit pointer to a 32-bit unicode char

        //      8 bit int types
        SignedByte = 0x0068,   // 8 bit signed int
        T_PINT1 = 0x0168,   // 16 bit pointer to 8 bit signed int
        T_PFINT1 = 0x0268,   // 16:16 far pointer to 8 bit signed int
        T_PHINT1 = 0x0368,   // 16:16 huge pointer to 8 bit signed int
        T_32PINT1 = 0x0468,   // 32 bit pointer to 8 bit signed int
        T_32PFINT1 = 0x0568,   // 16:32 pointer to 8 bit signed int
        T_64PINT1 = 0x0668,   // 64 bit pointer to 8 bit signed int

        UnsignedByte = 0x0069,   // 8 bit unsigned int
        T_PUINT1 = 0x0169,   // 16 bit pointer to 8 bit unsigned int
        T_PFUINT1 = 0x0269,   // 16:16 far pointer to 8 bit unsigned int
        T_PHUINT1 = 0x0369,   // 16:16 huge pointer to 8 bit unsigned int
        T_32PUINT1 = 0x0469,   // 32 bit pointer to 8 bit unsigned int
        T_32PFUINT1 = 0x0569,   // 16:32 pointer to 8 bit unsigned int
        T_64PUINT1 = 0x0669,   // 64 bit pointer to 8 bit unsigned int

        // 16 bit short types
        _16BitsSigned = 0x0011,   // 16 bit signed
        T_PSHORT = 0x0111,   // 16 bit pointer to 16 bit signed
        T_PFSHORT = 0x0211,   // 16:16 far pointer to 16 bit signed
        T_PHSHORT = 0x0311,   // 16:16 huge pointer to 16 bit signed
        T_32PSHORT = 0x0411,   // 32 bit pointer to 16 bit signed
        T_32PFSHORT = 0x0511,   // 16:32 pointer to 16 bit signed
        T_64PSHORT = 0x0611,   // 64 bit pointer to 16 bit signed

        _16BitsUnsigned = 0x0021,   // 16 bit unsigned
        T_PUSHORT = 0x0121,   // 16 bit pointer to 16 bit unsigned
        T_PFUSHORT = 0x0221,   // 16:16 far pointer to 16 bit unsigned
        T_PHUSHORT = 0x0321,   // 16:16 huge pointer to 16 bit unsigned
        T_32PUSHORT = 0x0421,   // 32 bit pointer to 16 bit unsigned
        T_32PFUSHORT = 0x0521,   // 16:32 pointer to 16 bit unsigned
        T_64PUSHORT = 0x0621,   // 64 bit pointer to 16 bit unsigned

        //      16 bit int types
        SignedShort = 0x0072,   // 16 bit signed int
        T_PINT2 = 0x0172,   // 16 bit pointer to 16 bit signed int
        T_PFINT2 = 0x0272,   // 16:16 far pointer to 16 bit signed int
        T_PHINT2 = 0x0372,   // 16:16 huge pointer to 16 bit signed int
        T_32PINT2 = 0x0472,   // 32 bit pointer to 16 bit signed int
        T_32PFINT2 = 0x0572,   // 16:32 pointer to 16 bit signed int
        T_64PINT2 = 0x0672,   // 64 bit pointer to 16 bit signed int

        UnisgnedShort = 0x0073,   // 16 bit unsigned int
        T_PUINT2 = 0x0173,   // 16 bit pointer to 16 bit unsigned int
        T_PFUINT2 = 0x0273,   // 16:16 far pointer to 16 bit unsigned int
        T_PHUINT2 = 0x0373,   // 16:16 huge pointer to 16 bit unsigned int
        T_32PUINT2 = 0x0473,   // 32 bit pointer to 16 bit unsigned int
        T_32PFUINT2 = 0x0573,   // 16:32 pointer to 16 bit unsigned int
        T_64PUINT2 = 0x0673,   // 64 bit pointer to 16 bit unsigned int

        //      32 bit long types
        _32BitsSigned = 0x0012,   // 32 bit signed
        T_ULONG = 0x0022,   // 32 bit unsigned
        T_PLONG = 0x0112,   // 16 bit pointer to 32 bit signed
        T_PULONG = 0x0122,   // 16 bit pointer to 32 bit unsigned
        T_PFLONG = 0x0212,   // 16:16 far pointer to 32 bit signed
        T_PFULONG = 0x0222,   // 16:16 far pointer to 32 bit unsigned
        T_PHLONG = 0x0312,   // 16:16 huge pointer to 32 bit signed
        T_PHULONG = 0x0322,   // 16:16 huge pointer to 32 bit unsigned

        _32BitsUnsigned = 0x0412,   // 32 bit pointer to 32 bit signed
        T_32PULONG = 0x0422,   // 32 bit pointer to 32 bit unsigned
        T_32PFLONG = 0x0512,   // 16:32 pointer to 32 bit signed
        T_32PFULONG = 0x0522,   // 16:32 pointer to 32 bit unsigned
        T_64PLONG = 0x0612,   // 64 bit pointer to 32 bit signed
        T_64PULONG = 0x0622,   // 64 bit pointer to 32 bit unsigned

        //      32 bit int types
        Integer = 0x0074,   // 32 bit signed int
        T_PINT4 = 0x0174,   // 16 bit pointer to 32 bit signed int
        T_PFINT4 = 0x0274,   // 16:16 far pointer to 32 bit signed int
        T_PHINT4 = 0x0374,   // 16:16 huge pointer to 32 bit signed int
        T_32PINT4 = 0x0474,   // 32 bit pointer to 32 bit signed int
        T_32PFINT4 = 0x0574,   // 16:32 pointer to 32 bit signed int
        T_64PINT4 = 0x0674,   // 64 bit pointer to 32 bit signed int

        UnsignedInteger = 0x0075,   // 32 bit unsigned int
        T_PUINT4 = 0x0175,   // 16 bit pointer to 32 bit unsigned int
        T_PFUINT4 = 0x0275,   // 16:16 far pointer to 32 bit unsigned int
        T_PHUINT4 = 0x0375,   // 16:16 huge pointer to 32 bit unsigned int
        T_32PUINT4 = 0x0475,   // 32 bit pointer to 32 bit unsigned int
        T_32PFUINT4 = 0x0575,   // 16:32 pointer to 32 bit unsigned int
        T_64PUINT4 = 0x0675,   // 64 bit pointer to 32 bit unsigned int

        //      64 bit quad types
        _64BitsSigned = 0x0013,   // 64 bit signed
        T_PQUAD = 0x0113,   // 16 bit pointer to 64 bit signed
        T_PFQUAD = 0x0213,   // 16:16 far pointer to 64 bit signed
        T_PHQUAD = 0x0313,   // 16:16 huge pointer to 64 bit signed
        T_32PQUAD = 0x0413,   // 32 bit pointer to 64 bit signed
        T_32PFQUAD = 0x0513,   // 16:32 pointer to 64 bit signed
        T_64PQUAD = 0x0613,   // 64 bit pointer to 64 bit signed

        _64BitsUnsigned = 0x0023,   // 64 bit unsigned
        T_PUQUAD = 0x0123,   // 16 bit pointer to 64 bit unsigned
        T_PFUQUAD = 0x0223,   // 16:16 far pointer to 64 bit unsigned
        T_PHUQUAD = 0x0323,   // 16:16 huge pointer to 64 bit unsigned
        T_32PUQUAD = 0x0423,   // 32 bit pointer to 64 bit unsigned
        T_32PFUQUAD = 0x0523,   // 16:32 pointer to 64 bit unsigned
        T_64PUQUAD = 0x0623,   // 64 bit pointer to 64 bit unsigned

        //      64 bit int types
        SignedLong = 0x0076,   // 64 bit signed int
        T_PINT8 = 0x0176,   // 16 bit pointer to 64 bit signed int
        T_PFINT8 = 0x0276,   // 16:16 far pointer to 64 bit signed int
        T_PHINT8 = 0x0376,   // 16:16 huge pointer to 64 bit signed int
        T_32PINT8 = 0x0476,   // 32 bit pointer to 64 bit signed int
        T_32PFINT8 = 0x0576,   // 16:32 pointer to 64 bit signed int
        T_64PINT8 = 0x0676,   // 64 bit pointer to 64 bit signed int

        UnsignedLong = 0x0077,   // 64 bit unsigned int
        T_PUINT8 = 0x0177,   // 16 bit pointer to 64 bit unsigned int
        T_PFUINT8 = 0x0277,   // 16:16 far pointer to 64 bit unsigned int
        T_PHUINT8 = 0x0377,   // 16:16 huge pointer to 64 bit unsigned int
        T_32PUINT8 = 0x0477,   // 32 bit pointer to 64 bit unsigned int
        T_32PFUINT8 = 0x0577,   // 16:32 pointer to 64 bit unsigned int
        T_64PUINT8 = 0x0677,   // 64 bit pointer to 64 bit unsigned int

        //      128 bit octet types
        T_OCT = 0x0014,   // 128 bit signed
        T_POCT = 0x0114,   // 16 bit pointer to 128 bit signed
        T_PFOCT = 0x0214,   // 16:16 far pointer to 128 bit signed
        T_PHOCT = 0x0314,   // 16:16 huge pointer to 128 bit signed
        T_32POCT = 0x0414,   // 32 bit pointer to 128 bit signed
        T_32PFOCT = 0x0514,   // 16:32 pointer to 128 bit signed
        T_64POCT = 0x0614,   // 64 bit pointer to 128 bit signed

        T_UOCT = 0x0024,   // 128 bit unsigned
        T_PUOCT = 0x0124,   // 16 bit pointer to 128 bit unsigned
        T_PFUOCT = 0x0224,   // 16:16 far pointer to 128 bit unsigned
        T_PHUOCT = 0x0324,   // 16:16 huge pointer to 128 bit unsigned
        T_32PUOCT = 0x0424,   // 32 bit pointer to 128 bit unsigned
        T_32PFUOCT = 0x0524,   // 16:32 pointer to 128 bit unsigned
        T_64PUOCT = 0x0624,   // 64 bit pointer to 128 bit unsigned

        //      128 bit int types
        T_INT16 = 0x0078,   // 128 bit signed int
        T_PINT16 = 0x0178,   // 16 bit pointer to 128 bit signed int
        T_PFINT16 = 0x0278,   // 16:16 far pointer to 128 bit signed int
        T_PHINT16 = 0x0378,   // 16:16 huge pointer to 128 bit signed int
        T_32PINT16 = 0x0478,   // 32 bit pointer to 128 bit signed int
        T_32PFINT16 = 0x0578,   // 16:32 pointer to 128 bit signed int
        T_64PINT16 = 0x0678,   // 64 bit pointer to 128 bit signed int

        T_UINT16 = 0x0079,   // 128 bit unsigned int
        T_PUINT16 = 0x0179,   // 16 bit pointer to 128 bit unsigned int
        T_PFUINT16 = 0x0279,   // 16:16 far pointer to 128 bit unsigned int
        T_PHUINT16 = 0x0379,   // 16:16 huge pointer to 128 bit unsigned int
        T_32PUINT16 = 0x0479,   // 32 bit pointer to 128 bit unsigned int
        T_32PFUINT16 = 0x0579,   // 16:32 pointer to 128 bit unsigned int
        T_64PUINT16 = 0x0679,   // 64 bit pointer to 128 bit unsigned int

        //      16 bit real types
        Float = 0x0046,   // 16 bit real
        T_PREAL16 = 0x0146,   // 16 bit pointer to 16 bit real
        T_PFREAL16 = 0x0246,   // 16:16 far pointer to 16 bit real
        T_PHREAL16 = 0x0346,   // 16:16 huge pointer to 16 bit real
        T_32PREAL16 = 0x0446,   // 32 bit pointer to 16 bit real
        T_32PFREAL16 = 0x0546,   // 16:32 pointer to 16 bit real
        T_64PREAL16 = 0x0646,   // 64 bit pointer to 16 bit real

        //      32 bit real types
        Real = 0x0040,   // 32 bit real
        T_PREAL32 = 0x0140,   // 16 bit pointer to 32 bit real
        T_PFREAL32 = 0x0240,   // 16:16 far pointer to 32 bit real
        T_PHREAL32 = 0x0340,   // 16:16 huge pointer to 32 bit real
        T_32PREAL32 = 0x0440,   // 32 bit pointer to 32 bit real
        T_32PFREAL32 = 0x0540,   // 16:32 pointer to 32 bit real
        T_64PREAL32 = 0x0640,   // 64 bit pointer to 32 bit real

        //      32 bit partial-precision real types
        T_REAL32PP = 0x0045,   // 32 bit PP real
        T_PREAL32PP = 0x0145,   // 16 bit pointer to 32 bit PP real
        T_PFREAL32PP = 0x0245,   // 16:16 far pointer to 32 bit PP real
        T_PHREAL32PP = 0x0345,   // 16:16 huge pointer to 32 bit PP real
        T_32PREAL32PP = 0x0445,   // 32 bit pointer to 32 bit PP real
        T_32PFREAL32PP = 0x0545,   // 16:32 pointer to 32 bit PP real
        T_64PREAL32PP = 0x0645,   // 64 bit pointer to 32 bit PP real

        //      48 bit real types
        T_REAL48 = 0x0044,   // 48 bit real
        T_PREAL48 = 0x0144,   // 16 bit pointer to 48 bit real
        T_PFREAL48 = 0x0244,   // 16:16 far pointer to 48 bit real
        T_PHREAL48 = 0x0344,   // 16:16 huge pointer to 48 bit real
        T_32PREAL48 = 0x0444,   // 32 bit pointer to 48 bit real
        T_32PFREAL48 = 0x0544,   // 16:32 pointer to 48 bit real
        T_64PREAL48 = 0x0644,   // 64 bit pointer to 48 bit real

        //      64 bit real types
        T_REAL64 = 0x0041,   // 64 bit real
        T_PREAL64 = 0x0141,   // 16 bit pointer to 64 bit real
        T_PFREAL64 = 0x0241,   // 16:16 far pointer to 64 bit real
        T_PHREAL64 = 0x0341,   // 16:16 huge pointer to 64 bit real
        T_32PREAL64 = 0x0441,   // 32 bit pointer to 64 bit real
        T_32PFREAL64 = 0x0541,   // 16:32 pointer to 64 bit real
        T_64PREAL64 = 0x0641,   // 64 bit pointer to 64 bit real

        //      80 bit real types
        T_REAL80 = 0x0042,   // 80 bit real
        T_PREAL80 = 0x0142,   // 16 bit pointer to 80 bit real
        T_PFREAL80 = 0x0242,   // 16:16 far pointer to 80 bit real
        T_PHREAL80 = 0x0342,   // 16:16 huge pointer to 80 bit real
        T_32PREAL80 = 0x0442,   // 32 bit pointer to 80 bit real
        T_32PFREAL80 = 0x0542,   // 16:32 pointer to 80 bit real
        T_64PREAL80 = 0x0642,   // 64 bit pointer to 80 bit real

        //      128 bit real types
        T_REAL128 = 0x0043,   // 128 bit real
        T_PREAL128 = 0x0143,   // 16 bit pointer to 128 bit real
        T_PFREAL128 = 0x0243,   // 16:16 far pointer to 128 bit real
        T_PHREAL128 = 0x0343,   // 16:16 huge pointer to 128 bit real
        T_32PREAL128 = 0x0443,   // 32 bit pointer to 128 bit real
        T_32PFREAL128 = 0x0543,   // 16:32 pointer to 128 bit real
        T_64PREAL128 = 0x0643,   // 64 bit pointer to 128 bit real

        //      32 bit complex types
        _32BitsComplex = 0x0050,   // 32 bit complex
        T_PCPLX32 = 0x0150,   // 16 bit pointer to 32 bit complex
        T_PFCPLX32 = 0x0250,   // 16:16 far pointer to 32 bit complex
        T_PHCPLX32 = 0x0350,   // 16:16 huge pointer to 32 bit complex
        T_32PCPLX32 = 0x0450,   // 32 bit pointer to 32 bit complex
        T_32PFCPLX32 = 0x0550,   // 16:32 pointer to 32 bit complex
        T_64PCPLX32 = 0x0650,   // 64 bit pointer to 32 bit complex

        //      64 bit complex types
        _64BitsComplex = 0x0051,   // 64 bit complex
        T_PCPLX64 = 0x0151,   // 16 bit pointer to 64 bit complex
        T_PFCPLX64 = 0x0251,   // 16:16 far pointer to 64 bit complex
        T_PHCPLX64 = 0x0351,   // 16:16 huge pointer to 64 bit complex
        T_32PCPLX64 = 0x0451,   // 32 bit pointer to 64 bit complex
        T_32PFCPLX64 = 0x0551,   // 16:32 pointer to 64 bit complex
        T_64PCPLX64 = 0x0651,   // 64 bit pointer to 64 bit complex

        //      80 bit complex types
        T_CPLX80 = 0x0052,   // 80 bit complex
        T_PCPLX80 = 0x0152,   // 16 bit pointer to 80 bit complex
        T_PFCPLX80 = 0x0252,   // 16:16 far pointer to 80 bit complex
        T_PHCPLX80 = 0x0352,   // 16:16 huge pointer to 80 bit complex
        T_32PCPLX80 = 0x0452,   // 32 bit pointer to 80 bit complex
        T_32PFCPLX80 = 0x0552,   // 16:32 pointer to 80 bit complex
        T_64PCPLX80 = 0x0652,   // 64 bit pointer to 80 bit complex

        //      128 bit complex types
        T_CPLX128 = 0x0053,   // 128 bit complex
        T_PCPLX128 = 0x0153,   // 16 bit pointer to 128 bit complex
        T_PFCPLX128 = 0x0253,   // 16:16 far pointer to 128 bit complex
        T_PHCPLX128 = 0x0353,   // 16:16 huge pointer to 128 bit real
        T_32PCPLX128 = 0x0453,   // 32 bit pointer to 128 bit complex
        T_32PFCPLX128 = 0x0553,   // 16:32 pointer to 128 bit complex
        T_64PCPLX128 = 0x0653,   // 64 bit pointer to 128 bit complex

        //      boolean types
        _8BitsBoolean = 0x0030,   // 8 bit boolean
        T_PBOOL08 = 0x0130,   // 16 bit pointer to  8 bit boolean
        T_PFBOOL08 = 0x0230,   // 16:16 far pointer to  8 bit boolean
        T_PHBOOL08 = 0x0330,   // 16:16 huge pointer to  8 bit boolean
        T_32PBOOL08 = 0x0430,   // 32 bit pointer to 8 bit boolean
        T_32PFBOOL08 = 0x0530,   // 16:32 pointer to 8 bit boolean
        T_64PBOOL08 = 0x0630,   // 64 bit pointer to 8 bit boolean

        _16BitsBoolean = 0x0031,   // 16 bit boolean
        T_PBOOL16 = 0x0131,   // 16 bit pointer to 16 bit boolean
        T_PFBOOL16 = 0x0231,   // 16:16 far pointer to 16 bit boolean
        T_PHBOOL16 = 0x0331,   // 16:16 huge pointer to 16 bit boolean
        T_32PBOOL16 = 0x0431,   // 32 bit pointer to 18 bit boolean
        T_32PFBOOL16 = 0x0531,   // 16:32 pointer to 16 bit boolean
        T_64PBOOL16 = 0x0631,   // 64 bit pointer to 18 bit boolean

        _32BitsBoolean = 0x0032,   // 32 bit boolean
        T_PBOOL32 = 0x0132,   // 16 bit pointer to 32 bit boolean
        T_PFBOOL32 = 0x0232,   // 16:16 far pointer to 32 bit boolean
        T_PHBOOL32 = 0x0332,   // 16:16 huge pointer to 32 bit boolean
        T_32PBOOL32 = 0x0432,   // 32 bit pointer to 32 bit boolean
        T_32PFBOOL32 = 0x0532,   // 16:32 pointer to 32 bit boolean
        T_64PBOOL32 = 0x0632,   // 64 bit pointer to 32 bit boolean

        _64BitsBoolean = 0x0033,   // 64 bit boolean
        T_PBOOL64 = 0x0133,   // 16 bit pointer to 64 bit boolean
        T_PFBOOL64 = 0x0233,   // 16:16 far pointer to 64 bit boolean
        T_PHBOOL64 = 0x0333,   // 16:16 huge pointer to 64 bit boolean
        T_32PBOOL64 = 0x0433,   // 32 bit pointer to 64 bit boolean
        T_32PFBOOL64 = 0x0533,   // 16:32 pointer to 64 bit boolean
        T_64PBOOL64 = 0x0633,   // 64 bit pointer to 64 bit boolean

        //      ???
        T_NCVPTR = 0x01f0,   // CV Internal type for created near pointers
        T_FCVPTR = 0x02f0,   // CV Internal type for created far pointers
        T_HCVPTR = 0x03f0,   // CV Internal type for created huge pointers
        T_32NCVPTR = 0x04f0,   // CV Internal type for created near 32-bit pointers
        T_32FCVPTR = 0x05f0,   // CV Internal type for created far 32-bit pointers
        T_64NCVPTR = 0x06f0,   // CV Internal type for created near 64-bit pointers
    }
}
