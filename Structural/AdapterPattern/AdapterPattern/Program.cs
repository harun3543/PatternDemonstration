// See https://aka.ms/new-console-template for more information
/*
    Adapter Pattern, istemci kodu için beklenen arabirimi uygulayan bir bağdaştırıcı sınıfını 
    tanımlar. Bu bağdaştırıcı sınıfı, uyarlanan nesnenin yöntemlerine yapılan çağrıları delege 
    ederek, uyumsuz arayüzü açığa çıkarmadan istemci koduyla etkileşime girmesini sağlar.
*/

using AdapterPattern;

OldPrinter printer = new OldPrinter();
PrinterAdapter adapter = new PrinterAdapter( printer );

adapter.Start();
adapter.Stop();
