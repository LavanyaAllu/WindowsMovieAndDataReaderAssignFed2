use WFA3DotNet

create table Movie(MovieId int primary key,MovieName varchar(30),ActorName varchar(20),TicketCollection int)


insert into Movie values(101,'bhahubali','prabhas',1000)
insert into Movie values(102,'krack','raviteja',1000)
insert into Movie values(103,'red','ram',1000)
insert into Movie values(104,'saho','prabhas',1000)
insert into Movie values(105,'solo','rohit',1000)
insert into Movie values(106,'rangdhe','nithin',1000)
insert into Movie values(107,'valmiki','varun tej',1000)
insert into Movie values(108,'janatha garage','NTR',1000)
insert into Movie values(109,'maharshi','mahesh babu',1000)
insert into Movie values(110,'Spyder','mahesh babu',1000)

select * from Movie

create proc sp_ShowMovieDetails
 @Movieid int
 as 
 begin
select MovieId,MovieName,Actorname,Ticketcollection
from Movie 
where MovieId=@Movieid
end 

execute sp_ShowMovieDetails 106

 create proc sp_UpdateMovie1
@MovieId int,
  @MovieName varchar(20),
  @ActorName varchar(20),
  @Ticketcollection int
   as
   begin
   update Movie set MovieName=@MovieName,ActorName= @ActorName,Ticketcollection=@Ticketcollection
   where MovieId=@MovieId
   end
  execute sp_UpdateMovie1 110,'linga','rajinikanth',800

  create proc sp_InsertMovie
@MovieId int,
  @MovieName varchar(20),
  @ActorName varchar(20),
  @Ticketcollection int
   as
   begin
insert into Movie values(@MovieId,@MovieName,@ActorName,@Ticketcollection)
end

execute sp_InsertMovie '111','kaleja','mahesh babu',30000

Create Table tblCustomer1 (
Cid int not null primary key identity(1,1),
CName varchar(30),
DOB Date,
City varchar(20)
)

insert into tblCustomer1 values ('lavanya','21-Nov-1999','Hyderabad')
insert into tblCustomer1 values ('vasudha','12-April-1999','Tirupathi')
insert into tblCustomer1 values ('amisha','25-July-1998','MP')
insert into tblCustomer1 values ('bindhu','01-March-2000','Vijayawada')
insert into tblCustomer1 values ('Ramya','21-June-1997','Mumbai')
insert into tblCustomer1 values ('Divya','25-Oct-1998','Guntur')
insert into tblCustomer1 values ('Pooja','13-Jul-1997','Vizag')
insert into tblCustomer1 values ('Mahi','30-Nov-1999','UP')

select * from tblCustomer1

