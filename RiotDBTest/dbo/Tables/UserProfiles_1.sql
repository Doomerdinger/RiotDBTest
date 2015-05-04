CREATE TABLE [dbo].[UserProfiles] (
    [LoginID]     INT               NOT NULL,
    [FirstNme]    [dbo].[FirstName] NOT NULL,
    [LastNme]     [dbo].[LastName]  NOT NULL,
    [StateLive]   CHAR (2)          NULL,
    [DateOfBirth] DATE              NULL,
    PRIMARY KEY CLUSTERED ([LoginID] ASC),
    CHECK ([DateOfBirth]>='19000101' AND [DateOfBirth]<=getdate()),
    CHECK ([StateLive]='IN' OR [StateLive]='IA' OR [StateLive]='IL' OR [StateLive]='MO')
);

