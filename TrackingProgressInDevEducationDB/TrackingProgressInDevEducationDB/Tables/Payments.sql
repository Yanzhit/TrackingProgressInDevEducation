CREATE TABLE [TrackingProgressInDevEducationDB].[Payments] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [StudentId] INT          NOT NULL,
    [PaymentTo] DATE         NOT NULL,
    [PaymentOn] DATE         NOT NULL,
    [Amount]    DECIMAL (18) NOT NULL,
    [Status]    BIT          NOT NULL,
    CONSTRAINT [PK_PAYMENTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Payment_fk0] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id]) ON UPDATE CASCADE
);

