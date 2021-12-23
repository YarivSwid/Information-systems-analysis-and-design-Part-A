--drop table CUSTOMERBIDS
--drop table CONTACTS
--drop table CUSTOMERINVITS
--drop table USERINVITS
--drop table BUSINESSMEETINGS
--drop table CUSTOMERS
--drop table CHATPARTS
--drop table [MESSAGES]
--drop table CHATS
--drop table USERS

--drop table PAYTERMS

--ENUMERATORS
--Payment Terms--
create table dbo.PAYTERMS(
	[Payment Term] varchar(50) not null
)
alter table dbo.PAYTERMS
add constraint PK_Payterms primary key ([Payment Term])

--Users
create table dbo.USERS(
	userID					int not null, --PK
	[password]				varchar(20) not null,
	joinDate				dateTime not null,
	firstName				varchar(20) not null,
	lastName				varchar(20) not null,
	birthday				date not null,
	serialID				int not null,
	email					varchar(40) not null,
	[role]					varchar(50) not null, --enum
	profilePicture			varchar(500) not null
)
alter table dbo.USERS
add constraint PK_Users primary key (userID)
go

--Chats--
create table dbo.CHATS(
	chatID			int not null, --PK
	[name]			varchar(30) not null,
	openingDT		datetime not null,
	[description]	varchar(200) not null,
	manager			int not null --FK users
	--CONNECTIONS
)
alter table dbo.CHATS
add constraint	PK_Chats primary key (chatID),
	constraint	FK_ChatManager foreign key (manager) references USERS(userID)
go

--Messages--
create table dbo.[MESSAGES](
	sentBy				int not null, --FK users, PK
	messageDT			datetime not null, --PK
	content				varchar(500) null, --not null?
	attachedPhoto		varchar(500) null,
	asaResponseToUser	int null, --FK messages
	asaResponseToDT		datetime null, --FK messages
	partOfChat			int not null --FK chats
)
alter table dbo.[MESSAGES]
add constraint	PK_Messages primary key (sentBy, messageDT),
	constraint	FK_MessageResponseTo foreign key (asaResponseToUser, asaResponseToDT) references [MESSAGES](sentBy, messageDT),
	constraint	FK_MessagePartOfChat foreign key (partOfChat) references CHATS(chatID)
go

--Chat Participates--
create table dbo.CHATPARTS(
	chatID			int not null, --PK, FK chats
	chatUser		int not null --PK, FK users
)
alter table dbo.CHATPARTS
add constraint	PK_ChatParts primary key (chatID, chatUser),
	constraint	FK_ChatPartsChat foreign key (chatID) references CHATS(chatID),
	constraint	FK_ChatPartsUser foreign key (chatUser) references USERS(userID)
go

--Customers--
create table dbo.CUSTOMERS(
	custID			int not null, --PK
	orgName			varchar(30) not null,
	district		varchar(20),
	deliveryAddress	varchar(100),
	buildingNumber	varchar(30),
	roomNumber		int
)
alter table dbo.CUSTOMERS
add constraint PK_Customers primary key (custID)

--Business Meetings--
create table dbo.BUSINESSMEETINGS(
	meetingID			int not null, --PK
	meetingDT			dateTime not null,
	notes				varchar(500) not null,
	createdBy			int not null --FK users
)
alter table dbo.BUSINESSMEETINGS
add constraint PK_BusinessMeetings primary key (meetingID),
	constraint FK_BusinessCreator foreign key (createdBy) references USERS (userID)

--Meeting Invitations-
create table dbo.USERINVITS(
	userID		int not null, --PK, FK users
	meetingID	int not null --PK, FK BusMeet
)
alter table dbo.USERINVITS
add constraint PK_UserInvits primary key (userID, meetingID),
	constraint FK_UserInvitsUser foreign key (userID) references USERS (userID),
	constraint FK_UserInvitsMeetimg foreign key (meetingID) references BUSINESSMEETINGS (meetingID)

create table dbo.CUSTOMERINVITS(
	custID		int not null, --PK, FK customers
	meetingID	int not null --PK, FK BusMeet
)
alter table dbo.CUSTOMERINVITS
add constraint PK_customerInvits primary key (custID, meetingID),
	constraint FK_CustomerInvitsCustomer foreign key (custID) references CUSTOMERS (custID),
	constraint FK_CustomerInvitsMeetimg foreign key (meetingID) references BUSINESSMEETINGS (meetingID)	

--Contacts--
create table dbo.CONTACTS(
	contactName		varchar(50) not null,
	phoneNumber		varchar(30) null,
	contactEmail	varchar(50) not null
)
alter table dbo.CONTACTS
add constraint PK_Contacts primary key (contactEmail)

--Customer Bids--
create table dbo.CUSTOMERBIDS(
	bidID			int not null,
	discount		float not null,
	paymentTerm		varchar(50) not null,
	madeBy			int not null
)
alter table dbo.CUSTOMERBIDS
add constraint PK_CustomerBids primary key (bidID),
	constraint FK_CustomerBidPaymentTerm foreign key (paymentTerm) references PAYTERMS ([Payment Term]),
	constraint FK_madeBy foreign key (madeBy) references USERS (userID)

--
