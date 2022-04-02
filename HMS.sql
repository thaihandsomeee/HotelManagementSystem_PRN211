create Database [PRN211_HMS]


create table [Staff]
(
	StaffId int identity(1,1) primary key,
	FullName nvarchar(50),
	DOB Date,
	PhoneNumber nvarchar(12),
	City nvarchar(50)
)

create table [Room]
(
	RoomId int identity(1,1) primary key,
	RoomName nvarchar(10),
	RoomDescription nvarchar(2000),
	RoomPrice float
)

create table [Booking]
(
	BookingId int identity(1,1) primary key,
	RoomId int foreign key references [Room](RoomId),
	StaffId int foreign key references [Staff](StaffId),
	CustomerId nvarchar(15),
	CustomerName nvarchar(50),
	CustomerPhone nvarchar(12),
	DateFrom Date,
	DateTo Date,	
)