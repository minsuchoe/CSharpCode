// 주어진 패스워드 문자열이 다름 규칙을 만족하는지 알려주는 CheckPassword(string password) 작성하세요.
// 1. 6~15자리까지만 가능
// 2. 연속으로 동일 문자가 나오지 않아야 함.
// 3. 적어도 하나의 소문자 포함
// 4. 적어도 하나의 대문자 포함
// 5. 적어도 하나의 특수 문자 포함 : !@#$%^&*()
// 6. 공백 문자(white space) 포함 불가

using System;

class MainClass {
  
  public static bool CheckPassword(string password) {
    
    int length = password.Length;
    
    if (!(5 < length && length < 16))
      return false;
   
    for (int i = 0; i < password.Length - 1; i++) {
      if (password[i] == password[i+1]) {
      return false;
      }
    }
    
    for (int i = 0; i < password.Length; i++) {
      char c = password[i];
      
      if (c == ' ')
        return false;
    }
    
    for (int i = 0; i < password.Length; i++) {
      char c = password[i];
      
      if (!(c == '!' || c == '@' || c == '#'
         || c == '$' || c == '%' || c == '^'
         || c == '&' || c == '*' || c == '('
         || c == ')' || c == '-' || c == '_'
         || c == '+' || c == '=' || c == '|'
         || c == '[' || c == ']' || c == '{'
         || c == '}' || c == '<' || c == '>'
         || c == '\\' || c == '~' || c == '`'))
        return false;
    }
    
    for (int i = 0; i < password.Length; i++) {
      char c = password[i];
      
      if (!('a' <= c || c <= 'z')) 
        return false;
    }
    
    for (int i = 0; i < password.Length; i++) {
      char c = password[i];
      
      if (!('A' <= c || c <= 'Z')) {
        return false;
      }
    }
    return true;
  }

  public static void Main (string[] args) {
    Console.WriteLine (CheckPassword("abcDE") == false);
    Console.WriteLine (CheckPassword("12345678901234567890") == false);
    
    
    Console.WriteLine (CheckPassword("abcDEFFFF_abc") == false);
    Console.WriteLine (CheckPassword("abcccDEF_abc") == false);
    Console.WriteLine (CheckPassword("abcDEF___abc") == false);
    
    
    Console.WriteLine (CheckPassword("DEF_DEF") == false);
    Console.WriteLine (CheckPassword("abc_abc") == false);
    
    
    Console.WriteLine (CheckPassword("abcDEFabcDEF") == false);
    Console.WriteLine (CheckPassword("abc!DEFabcDEF") == true);
    Console.WriteLine (CheckPassword("abc*DEFabcDEF") == true);
    Console.WriteLine (CheckPassword("abc@DEFabcDEF") == true);
    Console.WriteLine (CheckPassword("abc|DEFabcDEF") == true);
    Console.WriteLine (CheckPassword("ab[c]DE{F}ab+F") == true);
    
    
    Console.WriteLine (CheckPassword("abcDEF abcDEF") == false);
    
    Console.WriteLine (CheckPassword("abcDEF_abcDEF") == true);
    
  }
}