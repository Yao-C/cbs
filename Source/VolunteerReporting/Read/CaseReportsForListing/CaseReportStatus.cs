/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Read.CaseReportsForListing
{
    public enum CaseReportStatus
    {
        Success,
        TextMessageParsingError,
        UnknownDataCollector,
        TextMessageParsingErrorAndUnknownDataCollector
    }
}