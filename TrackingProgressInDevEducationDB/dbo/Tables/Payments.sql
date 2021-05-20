CREATE TABLE [dbo].[Payments] (
    [Id]        INT          NOT NULL,
    [StudentId] INT          NOT NULL,
    [PaymentTo] DATE         NOT NULL,
    [PaymentOn] DATE         NOT NULL,
    [Amount]    DECIMAL (18) NOT NULL,
    [Status]    BIT          NOT NULL,
    CONSTRAINT [PK_PAYMENTS] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Payment_fk0] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([Id]) ON UPDATE CASCADE
);

