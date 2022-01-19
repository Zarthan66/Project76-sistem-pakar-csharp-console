Console.WriteLine("==================================");
Console.WriteLine("   Sistem Pakar Penyakit Ginjal   ");
Console.WriteLine("==================================");

Console.WriteLine("\nDibawah ini adalah data gejala gejala yang digunakan untuk mendiagnosa penyakit anda");

Console.WriteLine("1. Sering buang air kecil");
Console.WriteLine("2. Buang air kecil terasa panas");
Console.WriteLine("3. Nyeri panggul");
Console.WriteLine("4. Urine keruh dan berbau busuk");
Console.WriteLine("5. Urine berdarah");
Console.WriteLine("6. Nanah pada urine");
Console.WriteLine("7. Nyeri pinggang");
Console.WriteLine("8. Nyeri perut");
Console.WriteLine("9. Mual dan muntah");
Console.WriteLine("10. Demam dan menggigil");
Console.WriteLine("11. Tekanan darah tinggi");
Console.WriteLine("12. Pembengkakan pada wajah dan kaki");
Console.WriteLine("13. Nyeri saat buang air kecil");
Console.WriteLine("14. Benjolan atau bengkak di sekitar punggung bawah dan pinggang");
Console.WriteLine("15. Nyeri punggung");
Console.WriteLine("16. Keringat banyak pada malam hari");
Console.WriteLine("17. Penurunan berat badan");
Console.WriteLine("18. Kehilangan nafsu makan");
Console.WriteLine("19. Pucat");
Console.WriteLine("20. Letih, Lesu");
Console.WriteLine("21. Tubuh mudah lelah");
Console.WriteLine("22. Kekurangan darah");
Console.WriteLine("23. Edema");
Console.WriteLine("24. Urine berbusa");
Console.WriteLine("25. Kulit gatal berkepanjangan");
Console.WriteLine("26. Pembengkakan pada mata, kaki atau tangan");
Console.WriteLine("27. Nyeri atau esensi tertekan di dada");
Console.WriteLine("28. Gangguan tidur");
Console.WriteLine("29. Kram dan kejang otot");
Console.WriteLine("30. Pusing");
Console.WriteLine("31. Disfungsi ereksi (pria)");
Console.WriteLine("32. Jumlah dan frekuensi urine berkurang");
Console.WriteLine("33. Pembengkakan pada tungkai");
Console.WriteLine("34. Gangguan irama jantung");
Console.WriteLine("35. Napas berbau tidak sedap");
Console.WriteLine("36. Muncul ruam atau rasa gatal dikulit");
Console.WriteLine("37. Nyeri atau pembekakan pada sendi");
Console.WriteLine("38. Tremor di tangan");
Console.WriteLine("39. Kejang");
Console.WriteLine("40. Koma");
Console.WriteLine("41. Buang air kecil sedikit");
Console.WriteLine("42. Gangguan keseimbangan");
Console.WriteLine("43. Sulit menelan");
Console.WriteLine("44. Keringat berlebih atau berkurang");
Console.WriteLine("45. Vagina kering");
Console.WriteLine("46. Penurunan libido");
Console.WriteLine("47. Sembelit atau diare");
Console.WriteLine("48. Gangguan berkemih, seperti mengompol atau sulit buang air kecil");
Console.WriteLine("49. Penglihatan buram atau ganda");
Console.WriteLine("50. Lumpuh pada salah satu sisi wajah");
Console.WriteLine("51. Jantung berdebar");
Console.WriteLine("52. Sesak napas");
Console.WriteLine("53. Sering merasa haus");
Console.WriteLine("54. Sering merasa lapar");
Console.WriteLine("55. Kulit luka tidak mudah sembuh");
Console.WriteLine("56. Suhu badan naik");
Console.WriteLine("57. Sensai terbakar di perut bawah");

// Jawaban dari user
string answer = "";

Console.WriteLine("\nMasukan gejala yang anda alami");
Console.WriteLine("Format: g1,g2,g3,g4,dst...");
Console.WriteLine("Contoh: 9,17,18,20,23,24");
Console.Write("\nUser: ");

answer = Console.ReadLine();

Console.Write("\nResult: ");

// Jika memenuhi semua gejala, print out tipe penyakitnya
if (answer == "5,8,9,10,15,18,21,32,33,34,35,36,37,38,39,40,52")
{
    Console.Write("Anda mengalami Gagal ginjal akut");
}
else if(answer == "1,5,9,11,17,18,19,25,26,27,28,29,30,31")
{
    Console.Write("Anda mengalami Gagal ginjal kronis");
}
else if(answer == "1,4,5,7,8,9,10,13")
{
    Console.Write("Anda mengalami Infeksi Ginjal");
}
else if(answer == "7,10,14,15,16,17,18,19,20,21,22")
{
    Console.Write("Anda mengalami Kanker Ginjal");
}
else if(answer == "9,17,18,20,23,24")
{
    Console.Write("Anda mengalami Sindrom Nefrotik");
}
else if(answer == "1,17,52,53,54,55")
{
    Console.Write("Anda mengalami Diabetes");
}
else if(answer == "1,3,5,8,41,56")
{
    Console.Write("Anda mengalami Infeksi Saluran Kemih");
}
else if (answer == "1,3,5,8,9,32,41,56")
{
    Console.Write("Anda mengalami Obstruksi Saluran Kemih");
}
else if (answer == "4,5,13,41,57")
{
    Console.Write("Anda mengalami Sistitis");
}
else if(answer == "42,43,44,45,46,47,48,49,50,51")
{
    Console.Write("Anda mengalami Nefropatik Diabetik");
}
else if (answer == "4,9,26,52")
{
    Console.Write("Anda mengalami Kencing Batu");
}
else if(answer == "1,2,4,5,7,8,9,10,15,41")
{
    Console.Write("Anda mengalami Batu Ginjal");
}
else if(answer == "1,2,3,4,5,6,7,8,9,10,11,12")
{
    Console.Write("Anda mengalami Sindrom Nefritik");
}
else
{
    Console.WriteLine("Penyakit tidak dapat teridentifikasi berdasarkan data yang ada.");
    Console.WriteLine("Pastikan Input mengikuti format sebagai berikut");
    Console.WriteLine("Format: g1,g2,g3,g4,dst...");
    Console.WriteLine("Contoh: 9,17,18,20,23,24");
}
Console.WriteLine();
