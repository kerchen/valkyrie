﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter3
{
    public class Page5 : IStaticCodeBook
    {
        public int Dimensions = 2;

        public byte[] LengthList = {
            1, 3, 4, 6, 6, 7, 7, 9, 9, 0, 5, 5, 7, 7, 7, 8,
            9, 9, 0, 5, 5, 7, 7, 8, 8, 9, 9, 0, 7, 7, 8, 8,
            8, 8, 10, 10, 0, 0, 0, 8, 8, 8, 8, 10, 10, 0, 0, 0,
            9, 9, 9, 9, 10, 10, 0, 0, 0, 9, 9, 9, 9, 10, 10, 0,
            0, 0, 10, 10, 10, 10, 11, 11, 0, 0, 0, 0, 0, 10, 10, 11,
            11
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -531628032;
        public int QuantDelta = 1611661312;
        public int Quant = 4;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            4,
            3,
            5,
            2,
            6,
            1,
            7,
            0,
            8
        };
    }
}