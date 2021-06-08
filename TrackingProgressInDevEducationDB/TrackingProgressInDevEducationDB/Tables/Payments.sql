CREATE TABLE [TrackingProgressInDevEducationDB].[Payments] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [StudentId] INT          NOT NULL,
    [PaymentTo] NVARCHAR(50)         NOT NULL,
    [PaymentOn] NVARCHAR(50)         NOT NULL,
    [Amount]    INT NOT NULL,
    [Status]    BIT          NOT NULL,
    CONSTRAINT [PK_PAYMENTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Payment_fk0] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id]) ON UPDATE CASCADE
);

