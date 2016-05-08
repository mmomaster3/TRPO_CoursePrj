CREATE TABLE [dbo].[Table] (
    [Id]             INT            IDENTITY(1,1) NOT NULL,
    [Service]        BIT            NOT NULL,
    [Sign]           BIT            NOT NULL,
    [Fund]           INT            NULL,
    [Responsability] BIT            NOT NULL,
    [What]           NVARCHAR (200) NULL,
    [Expenses]       BIT            NOT NULL,
    [Dependency]     BIT            NOT NULL,
    [Deposit]        INT            NULL,
    [Blueprint]      NVARCHAR (30)  NOT NULL,
    [Calculation]    BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

