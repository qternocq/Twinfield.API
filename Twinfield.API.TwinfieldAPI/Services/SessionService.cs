﻿using System.Threading.Tasks;
using Twinfield.API.TwinfieldAPI.Dto;
using Twinfield.API.TwinfieldAPI.Exceptions;
using TwinfieldSessionService;

namespace Twinfield.API.TwinfieldAPI.Services
{
    /// <summary>
    /// SessionService, uses the Twinfield SessionService API.
    /// </summary>
    /// <seealso cref="Twinfield.API.TwinfieldAPI.Services.AbstractService{TwinfieldSessionService.SessionSoapClient}" />
    public class SessionService : AbstractService<SessionSoapClient>
    {
        /// <summary>
        /// Gets or sets the session.
        /// </summary>
        /// <value>
        /// The session.
        /// </value>
        public Session Session { get; set; }

        /// <summary>
        /// Gets the service endpoint.
        /// </summary>
        /// <value>
        /// The service endpoint.
        /// </value>
        public override string ServiceEndpoint { get; } = "/webservices/session.asmx";

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionService"/> class.
        /// Uses the Session object to authorize against the service.
        /// </summary>
        /// <param name="session">The session.</param>
        public SessionService(Session session) : base(session.ClusterUri)
        {
            Session = session;
            SoapClient = new SessionSoapClient(GetServiceBinding(), GetEndpoint());
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                SoapClient.CloseAsync();
            }
        }

        /// <summary>
        /// Selects a company.
        /// </summary>
        /// <param name="companyCode">The company code.</param>
        /// <exception cref="InvalidCompanyException">Could not switch to company '{company}'</exception>
        public async Task SelectCompany(string companyCode)
        {
            var companySelectResult = await SoapClient.SelectCompanyAsync(new Header() { SessionID = Session.SessionId }, companyCode);

            if (companySelectResult.SelectCompanyResult != SelectCompanyResult.Ok)
                throw new InvalidCompanyException("Could not switch to company '{company}'");
        }

        /// <summary>
        /// Abandons the session (log out).
        /// </summary>
        public async Task Abandon()
        {
            await SoapClient.AbandonAsync(new Header() { SessionID = Session.SessionId });
        }

        /// <summary>
        /// Logout. Uses the Abandon call.
        /// </summary>
        public async Task Logout()
        {
            await Abandon();
        }
    }
}
