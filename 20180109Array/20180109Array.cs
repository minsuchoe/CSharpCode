using System;

class MainClass {
  public static void Main (string[] args) {
    
    /*
    int[] odd = new int[50];
    odd[0] = 1;
    odd[1] = 3;
    odd[2] = 5;
    odd[3] = 7;
    odd[4] = 9;
    odd[5] = 11;
    odd[6] = 13;
    odd[7] = 15;
    odd[8] = 17;
    odd[9] = 19;
    odd[10] = 21;
    odd[11] = 23;
    odd[12] = 25;
    odd[13] = 27;
    odd[14] = 29;
    odd[15] = 31;
    odd[16] = 33;
    odd[17] = 35;
    odd[18] = 37;
    odd[19] = 39;
    odd[20] = 41;
    odd[21] = 43;
    odd[22] = 45;
    odd[23] = 47;
    odd[24] = 49;
    odd[25] = 51;
    odd[26] = 53;
    odd[27] = 55;
    odd[28] = 57;
    odd[29] = 59;
    odd[30] = 61;
    odd[31] = 63;
    odd[32] = 65;
    odd[33] = 67;
    odd[34] = 69;
    odd[35] = 71;
    odd[36] = 73;
    odd[37] = 75;
    odd[38] = 77;
    odd[39] = 79;
    odd[40] = 81;
    odd[41] = 83;
    odd[42] = 85;
    odd[43] = 87;
    odd[44] = 89;
    odd[45] = 91;
    odd[46] = 93;
    odd[47] = 95;
    odd[48] = 97;
    odd[49] = 99;
    */
    
    int[] oddArr = new int[50];
    
    for (int i = 0; i < 50; i++) {
      oddArr [i] = i * 2 + 1;
      Console.WriteLine(oddArr[i]);
    }
  }
}