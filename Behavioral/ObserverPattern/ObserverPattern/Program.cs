// See https://aka.ms/new-console-template for more information

using ObserverPattern;

Stock stock1 = new Stock("domates", 23.3);
Stock stock2 = new Stock("patates", 35.3);
Stock stock3 = new Stock("sugar", 12.3);
Stock stock4 = new Stock("fish", 78.3);
StockMarket stockMarket = new StockMarket();

stockMarket.AddObserver(stock1);
stockMarket.AddObserver(stock2);
stockMarket.AddObserver(stock3);
stockMarket.AddObserver(stock4);

stockMarket.UpdatePrice();
