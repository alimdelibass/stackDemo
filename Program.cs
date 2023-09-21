// Karakaterler icin bir yigin sinifi.
   using System;
   class Stack {
      // bu uyeler private‘tir
      
char[] stck; // yigini tutar
      int tos;     // yiginin tepesinin indeksi
      // buyuklugu bilinen bir bos Stack yapilandir
      public Stack(int size) {
         stck = new char[size]; // yigin icin bellek alani ayir
tos = 0; }
      // Yigindan bir Stack yapilandir.
      public Stack(Stack ob) {
// yigin icin bellek alani ayir
   stck = new char[ob.stck.Length];
   // elemanlari yeni yigina kopyala
   for(int i=0; i < ob.tos; i++)
      stck[i] = ob.stck[i];
   // yeni yigin icin tos‘u ayarla
   tos = ob.tos;
}
// Karakterleri yigina ekle.
public void push(char ch) {
   if(tos == stck.Length) {
      Console.WriteLine(― -- Stack is full.‖);
return; }
   stck[tos] = ch;
tos++; }
// Yigindan bir karakter cikar.
public char pop() {
   if(tos == 0) {
      Console.WriteLine(― -- Stack is empty.‖);
      return (char) 0;
}
tos--;
      return stck[tos];
   }
   // Yigin doluysa true dondur.
   public bool full() {
      return tos==stck.Length;
   }
   // Yigin bossa true dondur.
   public bool empty() {
      return tos==0;
   }
   // Yiginin toplam kapasitesini dondur.
   public int capacity() {
      return stck.Length;
   }
   // Su an yiginda olan nesnelerin sayisini dondur.
   public int getNum() {
return tos; }
}
// Stack sinifini goster.
class StackDemo {
   public static void Main() {
      Stack stk1 = new Stack(10);
      char ch;
      int i;
// stk1‘e birkac karakter yerlestir 
Console.WriteLine(―Push A through Z onto stk1.‖); for(i = 0; !stk1.full(); i++)
         stk1.push((char) ('A‘ + i));
// stck1‘in bir kopyasini olustur
Stack stk2 = new Stack(stk1);
// stk1‘in icerigini goster.
Console.Write(―Contents of stk1: ‖);
while( !stk1.empty() ) {
   ch = stk1.pop();
   Console.Write(ch);
}
Console.WriteLine();
Console.Write(―Contents of stk2: ‖);
while ( !stk2.empty() ) {
   ch = stk2.pop();
Console.Write(ch);
         }
         Console.WriteLine(―\n‖);
      }
}