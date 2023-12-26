CREATE TABLE UnitRank(
	id integer primary key, -- no identity, so you can control the values
	UnitRank varchar(14) not null unique
);

INSERT INTO UnitRank(id, UnitRank)
values 
	(1,'BattleReady'),
	(2,'Blooded'),
	(3,'BattleHardened'),
	(4,'Heroic'),
	(5,'Legendary');

CREATE TABLE Rosters(
	Id int primary key,
	RosterName varchar(255),
	PlayerName varchar(255),
	TotalSupply int,
	UsedSupply int,
	BattlesFought int,
	BattlesWon int,
	RequisitionPoints int,
	Records Text,
);

CREATE TABLE CrusadeUnits(
	Id int primary key,
	UnitName varchar(255),
	PointsValue int,
	CrusadePoints int,
	UnitType varchar(255),
	SubKeywords varchar(255),
	UnitRank int FOREIGN KEY REFERENCES UnitRank(id),
	Equipment varchar(255),
	Upgrades varchar(255),
	Badges varchar(255),
	BattlesPlayed int,
	BattlesSurvived int,
	UnitsDestroyed int,
	BattleHonours Text,
	BattleScars Text
);