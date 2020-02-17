using KaiTrade.Interfaces;
using System;
using System.Collections.Generic;

namespace K2DataObjects
{
    public class TestUtils
    {
        public const string VenueCode = "V9999";
        public const string AccountCode = "A12345";
        public const string AccountId = "AX12345876";
        public const string UserId = "UX998877665547";
        public const string UserName = "Fred Quimby";
        public const string ClOrdId = "fred123CloXYZ1";
        public const string OrigClOrdId = "fred123CloXYZ1";
        public const string ProductId = "prdepcme123456789";
        public const string Mnemonic = "EP";
        public const string OrderIdentity = "OR12345876";
        public const string ExecRefID = "ER1234567890";
        public const string ExchangeCode = "K3TEXCH";
        public const string DriverCode = "K3SIM";
        public const string MaturityDate = "20140322";
        public const string MMY = "0314";
        public const string FirmCode = "ZZZZ";
        public const string HeaderId = "BLUE";
        public const string UserPwd = "abced";
        public const string SignalName = "SN:12345";

        public static Account GetTestAccount()
        {
            return new Account()
            {
                AccountCode = AccountCode,
                ID = Guid.NewGuid().ToString(),
                FirmCode = FirmCode,
                LongName = DateTime.UtcNow.Ticks.ToString(),
                VenueCode = VenueCode,
                UserId = UserId
            };
        }

        public static User GetTestUser()
        {
            return new User()
            {
                UserID = UserId,
                UserPwd = UserPwd,
                K2Config = "<>",
                UserName = UserName,
                Enabled = false
            };
        }

        public static Order GetTestOrder()
        {
            Order order1 = new Order();
            order1.Identity = "OR" + DateTime.UtcNow.Ticks.ToString();
            order1.Account = "A12345";
            order1.AccountIdentity = "AX12345876";
            order1.AlgoName = string.Empty;
            order1.AutoTradeProcessCount = 0;
            order1.AvgPx = new Decimal(199, 0, 0, false, (byte)2);
            order1.ClientAssignedID = "myorder1234";
            order1.ClOrdID = "fred123CloXYZ1";
            order1.CorrelationID = "ax123456789";
            order1.CumQty = new Decimal(99);
            order1.Description = "a test order";
            order1.Expiration = 9999L;
            Order order2 = order1;
            DateTime dateTime1 = DateTime.Now;
            dateTime1 = dateTime1.ToUniversalTime();
            string str1 = dateTime1.ToString();
            order2.ExpireDate = str1;
            order1.ExtendedOrdType = "KICEBERG";
            order1.ExtendedOrdTypeParameters = (string[])null;
            order1.HandlInst = "1";
            order1.IsAutoTrade = false;
            order1.K2Parameters = new List<IParameter>();
            order1.LastOrderCommand = LastOrderCommand.none;
            order1.LastPx = new Decimal(0, 0, 0, false, (byte)1);
            order1.LastQty = new Decimal(1);
            order1.LeavesQty = new Decimal(2);
            order1.LocateReqd = "n";
            order1.LocationID = string.Empty;
            order1.MaxFloor = 12L;
            order1.Mnemonic = "EP";
            order1.OCAGroupName = string.Empty;
            order1.OrderID = "TE9988776655";
            order1.OrderQty = 2L;
            order1.OrdStatus = "New Order";
            order1.OrdType = "LIMIT";
            order1.OrigClOrdID = "fred123CloXYZ1";
            order1.ParentIdentity = string.Empty;
            order1.Price = new Decimal(9988, 0, 0, false, (byte)2);
            order1.ProductIdentity = "prdepcme123456789";
            order1.QuantityLimit = new Decimal(2);
            order1.SessionID = string.Empty;
            order1.ShortSaleLocate = string.Empty;
            order1.Side = "BUY";
            order1.StopPx = new Decimal(0);
            order1.StrategyName = "STRABC";
            order1.SystemDate = DateTime.Now;
            order1.Tag = "blurg";
            order1.Text = "my text note";
            order1.TimeInForce = "DAY";
            order1.TradeVenue = "V9999";
            Order order3 = order1;
            DateTime dateTime2 = DateTime.Now;
            dateTime2 = dateTime2.ToUniversalTime();
            string str2 = dateTime2.ToString();
            order3.TransactTime = str2;
            order1.TriggerOrderID = string.Empty;
            order1.User = "UX998877665547";
            return order1;
        }

        public static Fill GetTestFill()
        {
            return new Fill()
            {
                Account = "AX12345876",
                AvgPx = new Decimal(12345, 0, 0, false, (byte)2),
                ClOrdID = "fred123CloXYZ1",
                CumQty = new Decimal(99),
                ExecRefID = "ER1234567890",
                ExecReport = "",
                ExecType = "Fill",
                FillQty = new Decimal(1),
                LastPx = new Decimal(889, 0, 0, false, (byte)1),
                LeavesQty = new Decimal(1),
                Mnemonic = "EP",
                OrderID = "TE9988776655",
                OrderIdentity = "OR12345876",
                OrderStatus = "Partial Fill",
                OrdRejReason = string.Empty,
                OrigClOrdID = "fred123CloXYZ1",
                ProductID = "prdepcme123456789",
                Sequence = 1L,
                SystemTime = DateTime.Now,
                Text = "test fill",
                Ticks = DateTime.UtcNow.Ticks
            };
        }

        public static Strategy GetTestStrategy(string userIdent, string userStrategyName)
        {
            return new Strategy()
            {
                Identity = "TS" + DateTime.Now.ToString(),
                UserName = userStrategyName,
                User = "UX998877665547",
                Account = "A12345",
                AutoConnectTrg = false,
                AutoCreate = false,
                CancelOnExit = true,
                ConditionInterval = 0,
                CorrelationID = "Corr1234",
                DataMnemonic = "EP",
                EndTime = DateTime.Now,
                EntryTriggerName = "",
                ExitTriggerName = "",
                FlattenOnExit = false,
                Info = "No Info",
                Initialized = false,
                K2Parameters = (List<IParameter>)null,
                MaxEntries = 1,
                MaxFloor = new double?(1.0),
                MaxIterations = 1,
                MaxPrice = 10.0,
                MinPrice = 9.0,
                Mnemonic = "ES",
                ORAlgorithmName = "",
                OrdType = "LIMIT",
                ParameterBag = "",
                Price = 12.1,
                ProductID = "prdepcme123456789",
                PXAlgorithmName = "",
                Qty = 1.0,
                QtyLimit = 2.0,
                RunIdentifier = "0",
                SessionID = "",
                ShortSaleLocate = "",
                Side = "BUY",
                SignalNames = new List<string>(),
                StartTime = DateTime.Now,
                State = StrategyState.init,
                StopPx = 11.11,
                TimeInForce = "GTC",
                TriggerName = "TRIGXYZ",
                TSQueryGroupPath = "",
                Type = StrategyType.user,
                UseStrategyTimes = false
            };
        }

        public static TradeVenue GetTestVenue()
        {
            return new TradeVenue()
            {
                AccountNumber = "12345",
                BeginString = "",
                CancelBag = "",
                Code = "V" + DateTime.UtcNow.Ticks.ToString(),
                DataFeedVenue = "SIM",
                DefaultCFICode = "FXXXXX",
                DefaultCurrencyCode = "USD",
                DefaultSecurityExchange = "K3TEXCH",
                DriverCode = "SIM",
                MessageExchange = (List<IMQExchange>)null,
                Name = "TestVenue",
                NOSBag = "",
                ReplaceBag = "",
                RoutingKey = (List<IMQRoutingKey>)null,
                SID = "",
                TargetVenue = "V3",
                TID = "99",
                UseSymbol = true
            };
        }

        public static Exchange GetTestExchange()
        {
            return new Exchange()
            {
                ExchangeCode = "K3TEXCH",
                Name = "K3 Test Exchange"
            };
        }

        public static Product GetTestProduct()
        {
            return new Product()
            {
                Active = true,
                BrokerService = string.Empty,
                CFICode = "FXXXXX",
                Commodity = "ES",
                ContractSize = new Decimal?(new Decimal(50)),
                Currency = "USD",
                DepthLevelCount = 0,
                DriverID = "KTSIM",
                Exchange = "K3TEXCH",
                ExDestination = "ZZ",
                GenericName = "ES",
                IDSource = string.Empty,
                InitialMargin = new Decimal?(new Decimal(1250)),
                LongName = "Test Product",
                MaintainenceMargin = new Decimal?(new Decimal(99)),
                MaturityDate = "20140322",
                MMY = "0314",
                Mnemonic = "EP",
                NumberDecimalPlaces = 0,
                PriceFeedQuantityMultiplier = 1,
                QtyIncrement = 1,
                SecurityID = "ES04XX",
                StrikePrice = new Decimal?(),
                Symbol = "EP",
                SyntheticPriceCalcName = string.Empty,
                Tag = "no tag",
                TickSize = new Decimal?(new Decimal(15, 0, 0, false, (byte)1)),
                TickValue = new Decimal?(new Decimal(1)),
                TradeVenue = "V9999"
            };
        }

        public static TradeSignal GetTestSignal(string userId, string name)
        {
            return new TradeSignal()
            {
                Mnemonic = "EP",
                OrdQty = 1.0,
                Price = 22.1,
                SignalType = TradeSignalType.enter,
                OrdType = "LIMIT",
                Name = name,
                Side = "BUY",
                Origin = "unitTest",
                TimeCreated = DateTime.Now,
                TimeValid = 100L,
                User = userId,
                Text = " a test signal" + DateTime.UtcNow.Ticks.ToString()
            };
        }

        public static PriceBar GetTestPriceBar()
        {
            return new PriceBar()
            {
                Mnemonic = "EP",
                AskVolume = new Decimal?(new Decimal(2)),
                Avg = new Decimal?(new Decimal(1)),
                BidVolume = new Decimal?(new Decimal(3)),
                Close = new Decimal(90),
                High = new Decimal(101),
                ItemSize = 2,
                ItemType = 0,
                Low = new Decimal(90),
                Open = new Decimal(95),
                RequestID = DateTime.UtcNow.Ticks.ToString(),
                TimeStamp = DateTime.UtcNow.Ticks,
                Volume = new Decimal?(new Decimal(20))
            };
        }

        public static CurveValue GetTestCurveValue()
        {
            return new CurveValue()
            {
                HeaderID = "BLUE",
                ItemSize = 1,
                ItemType = 1,
                Mnemonic = "EP",
                RequestID = "CV:" + DateTime.UtcNow.Ticks.ToString(),
                TimeStamp = DateTime.UtcNow.Ticks,
                Value = new Decimal(9999, 0, 0, false, (byte)2)
            };
        }
    }
}
