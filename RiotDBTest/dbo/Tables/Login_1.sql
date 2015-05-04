CREATE TABLE [dbo].[Login] (
    [LoginID]  INT          IDENTITY (0, 5) NOT NULL,
    [Username] VARCHAR (15) NOT NULL,
    [Password] TEXT         CONSTRAINT [DF_Login_Password] DEFAULT ('badgerbadger') NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([LoginID] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);

