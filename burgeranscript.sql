/*
SQLyog v4.05
Host - 5.5.28 : Database - db_burgeran
*********************************************************************
Server version : 5.5.28
*/


create database if not exists `db_burgeran`;

USE `db_burgeran`;

/*Table structure for table `db_burgeran`.`admins` */

drop table if exists `db_burgeran`.`admins`;

CREATE TABLE `admins` (
  `AdminID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`AdminID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`admins` */

/*Table structure for table `db_burgeran`.`cashier` */

drop table if exists `db_burgeran`.`cashier`;

CREATE TABLE `cashier` (
  `CashierID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`CashierID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`cashier` */

insert into `db_burgeran`.`cashier` values (2,'TonYacapin','Ton','Yacapin','yacapinton@gmail.com','09153082500'),(3,'Hello','dasd','dasd','dasd','dasd'),(4,'','','','',''),(5,'Marc','Marc','Suarez','suani@gmail.com','09999999999'),(6,'mel','Marc','Suarez','suani@gmail.com','09999999999');

/*Table structure for table `db_burgeran`.`combinedviews` */

drop table if exists `db_burgeran`.`combinedviews`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `combinedviews` AS select `tc`.`CashierName` AS `TopCashierName`,`tc`.`CashierSales` AS `TopCashierSales`,`ts`.`TotalSales` AS `TotalSales`,`tsp`.`ProductName` AS `TopSellingProduct`,`tsp`.`ProductDescription` AS `TopSellingProductDescription`,`tsp`.`TotalQuantitySold` AS `TopSellingProductQuantity` from ((`topcashier` `tc` join `totalsalesview` `ts` on((1 = 1))) left join `topsellingproducts` `tsp` on((1 = 1)));

/*Data for the table `db_burgeran`.`combinedviews` */

insert into `db_burgeran`.`combinedviews` values ('ton','44535.00','55595.00','Hotdog','Classic hotdog with toppings',317),('ton','44535.00','55595.00','Burger','Delicious beef burger',306),('ton','44535.00','55595.00','ChocolateCake','Decadent chocolate cake',210),('ton','44535.00','55595.00','IceTea','Iced tea, your way',11),('ton','44535.00','55595.00','Coke','Refreshing Coca-Cola',9),('ton','44535.00','55595.00','Halo-Halo','Filipino mixed dessert',1);

/*Table structure for table `db_burgeran`.`login` */

drop table if exists `db_burgeran`.`login`;

CREATE TABLE `login` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `UserRole` enum('Admin','Cashier','Manager') NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`login` */

insert into `db_burgeran`.`login` values (1,'ton','ton','Cashier',1),(2,'admin','admin','Admin',1),(3,'manager','manager','Manager',1),(4,'Cashier','Cashier','Cashier',1),(7,'Hello','12345','Cashier',1),(8,'','12345','Cashier',0),(9,'Marc','12345','Cashier',0),(10,'mel','12345','Cashier',0);

/*Table structure for table `db_burgeran`.`loginrecords` */

drop table if exists `db_burgeran`.`loginrecords`;

CREATE TABLE `loginrecords` (
  `LoginRecordID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) DEFAULT NULL,
  `LoginTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`LoginRecordID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `loginrecords_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `login` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`loginrecords` */

insert into `db_burgeran`.`loginrecords` values (1,1,'2023-10-27 09:49:31','Login'),(2,1,'2023-10-27 09:50:29','Login'),(3,3,'2023-10-27 09:51:26','Login'),(4,2,'2023-10-27 09:51:34','Login'),(5,3,'2023-10-27 11:02:57','Login'),(6,3,'2023-10-27 11:06:02','Login'),(7,4,'2023-11-14 10:15:06','Login'),(8,3,'2023-11-14 10:15:22','Login'),(9,2,'2023-11-14 10:15:47','Login');

/*Table structure for table `db_burgeran`.`managers` */

drop table if exists `db_burgeran`.`managers`;

CREATE TABLE `managers` (
  `ManagerID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ManagerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`managers` */

/*Table structure for table `db_burgeran`.`orders` */

drop table if exists `db_burgeran`.`orders`;

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `CashierID` int(11) DEFAULT NULL,
  `OrderDate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `TotalAmount` decimal(10,2) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `CashierName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `CashierID` (`CashierID`),
  KEY `ProductId_idx` (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`orders` */

insert into `db_burgeran`.`orders` values (8,1,'2023-09-26 00:00:00','20.00',4,'1','ton'),(9,1,'2023-09-26 00:00:00','40.00',8,'1','ton'),(10,1,'2023-09-26 00:00:00','50.00',2,'1','ton'),(11,1,'2023-09-26 12:04:55','120.00',5,'6','ton'),(12,1,'2023-09-26 13:22:21','350.00',2,'7','ton'),(13,1,'2023-09-26 13:22:21','80.00',5,'4','ton'),(14,1,'2023-09-26 15:00:46','6000.00',1,'100','ton'),(15,4,'2023-09-26 15:01:49','5000.00',2,'100','Cashier'),(16,4,'2023-09-26 15:01:49','6000.00',1,'100','Cashier'),(17,1,'2023-09-26 15:28:49','6000.00',1,'100','Ton'),(18,1,'2023-10-24 15:28:01','60.00',1,'1','ton'),(19,1,'2023-10-24 15:28:01','20.00',4,'1','ton'),(20,1,'2023-10-24 15:28:01','45.00',7,'1','ton'),(21,1,'2023-10-24 15:40:24','20.00',4,'1','ton'),(22,1,'2023-10-24 15:40:24','20.00',5,'1','ton'),(23,1,'2023-10-27 07:43:17','450.00',2,'9','ton'),(24,1,'2023-10-27 07:43:17','120.00',4,'6','ton'),(25,1,'2023-10-27 08:31:08','5000.00',2,'100','ton'),(26,1,'2023-10-27 08:31:39','5000.00',2,'100','ton'),(27,1,'2023-10-27 08:36:20','240.00',1,'4','ton'),(28,1,'2023-10-27 09:22:19','900.00',8,'9','ton'),(29,1,'2023-10-27 09:22:19','10000.00',8,'100','ton'),(30,1,'2023-10-27 09:22:26','10000.00',8,'100','ton'),(31,4,'2023-11-14 10:15:12','60.00',1,'1','cashier');

/*Table structure for table `db_burgeran`.`products` */

drop table if exists `db_burgeran`.`products`;

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Description` text,
  `Price` decimal(10,2) NOT NULL,
  `Category` varchar(255) DEFAULT NULL,
  `StockQuantity` int(11) DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`products` */

insert into `db_burgeran`.`products` values (1,'Burger','Delicious beef burger','60.00','Main',195),(2,'Hotdog','Classic hotdog with toppings','50.00','Main',200),(3,'Fries','Crispy potato fries','40.00','Side',200),(4,'Coke','Refreshing Coca-Cola','20.00','Drink',200),(5,'IceTea','Iced tea, your way','20.00','Drink',200),(6,'SansRival','Sweet sans rival dessert','30.00','Dessert',200),(7,'Halo-Halo','Filipino mixed dessert','45.00','Dessert',200),(8,'ChocolateCake','Decadent chocolate cake','100.00','Dessert',200);

/*Table structure for table `db_burgeran`.`systemupdaterecords` */

drop table if exists `db_burgeran`.`systemupdaterecords`;

CREATE TABLE `systemupdaterecords` (
  `UpdateID` int(11) NOT NULL AUTO_INCREMENT,
  `UpdateDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UpdateDescription` text,
  `UpdatedBy` int(11) DEFAULT NULL,
  `UpdatedByManager` int(11) DEFAULT NULL,
  PRIMARY KEY (`UpdateID`),
  KEY `UpdatedBy` (`UpdatedBy`),
  KEY `UpdatedByManager` (`UpdatedByManager`),
  CONSTRAINT `systemupdaterecords_ibfk_1` FOREIGN KEY (`UpdatedBy`) REFERENCES `admins` (`AdminID`),
  CONSTRAINT `systemupdaterecords_ibfk_2` FOREIGN KEY (`UpdatedByManager`) REFERENCES `managers` (`ManagerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `db_burgeran`.`systemupdaterecords` */

/*Table structure for table `db_burgeran`.`topcashier` */

drop table if exists `db_burgeran`.`topcashier`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `topcashier` AS select `orders`.`CashierName` AS `CashierName`,sum(`orders`.`TotalAmount`) AS `CashierSales` from `orders` group by `orders`.`CashierName` order by sum(`orders`.`TotalAmount`) desc limit 1;

/*Data for the table `db_burgeran`.`topcashier` */

insert into `db_burgeran`.`topcashier` values ('ton','44535.00');

/*Table structure for table `db_burgeran`.`topsellingproducts` */

drop table if exists `db_burgeran`.`topsellingproducts`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `topsellingproducts` AS select `p`.`ProductID` AS `ProductID`,`p`.`Name` AS `ProductName`,`p`.`Description` AS `ProductDescription`,sum(`oi`.`Quantity`) AS `TotalQuantitySold` from (`products` `p` join `orders` `oi` on((`p`.`ProductID` = `oi`.`ProductID`))) group by `p`.`ProductID`,`p`.`Name`,`p`.`Description` order by sum(`oi`.`Quantity`) desc;

/*Data for the table `db_burgeran`.`topsellingproducts` */

insert into `db_burgeran`.`topsellingproducts` values (2,'Hotdog','Classic hotdog with toppings',317),(1,'Burger','Delicious beef burger',306),(8,'ChocolateCake','Decadent chocolate cake',210),(5,'IceTea','Iced tea, your way',11),(4,'Coke','Refreshing Coca-Cola',9),(7,'Halo-Halo','Filipino mixed dessert',1);

/*Table structure for table `db_burgeran`.`totalsalesview` */

drop table if exists `db_burgeran`.`totalsalesview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `totalsalesview` AS select sum(`orders`.`TotalAmount`) AS `TotalSales` from `orders`;

/*Data for the table `db_burgeran`.`totalsalesview` */

insert into `db_burgeran`.`totalsalesview` values ('55595.00');
