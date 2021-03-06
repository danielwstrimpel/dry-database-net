﻿namespace DatabaseTowel
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Threading.Tasks;

    public interface IExecuteScalarStoredProcedure
    {
        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        /// <exception cref="DatabaseTowelException">
        /// Failed to successfully execute the scalar stored procedure.
        /// </exception>
        object ExecuteScalarStoredProcedure(string storedProcedureName, IEnumerable<DbParameter> parameters);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="errorContext">The error context.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        object ExecuteScalarStoredProcedure(string storedProcedureName, IEnumerable<DbParameter> parameters, Func<DatabaseTowelException, object> errorContext);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="connection">The connection.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        /// <exception cref="DatabaseTowelException">
        /// Failed to successfully execute the scalar stored procedure.
        /// </exception>
        object ExecuteScalarStoredProcedure(string storedProcedureName, IEnumerable<DbParameter> parameters, IDbConnection connection);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="errorContext">The error context.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        object ExecuteScalarStoredProcedure(string storedProcedureName, IEnumerable<DbParameter> parameters, IDbConnection connection, Func<DatabaseTowelException, object> errorContext);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result, asynchronously.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        /// <exception cref="DatabaseTowelException">
        /// Failed to successfully execute the scalar stored procedure.
        /// </exception>
        Task<object> ExecuteScalarStoredProcedureAsync(string storedProcedureName, IEnumerable<DbParameter> parameters);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result, asynchronously.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="errorContext">The error context.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        Task<object> ExecuteScalarStoredProcedureAsync(string storedProcedureName, IEnumerable<DbParameter> parameters, Func<DatabaseTowelException, Task<object>> errorContext);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result, asynchronously.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="connection">The connection.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        /// <exception cref="DatabaseTowelException">
        /// Failed to successfully execute the scalar stored procedure.
        /// </exception>
        Task<object> ExecuteScalarStoredProcedureAsync(string storedProcedureName, IEnumerable<DbParameter> parameters, IDbConnection connection);

        /// <summary>
        /// Executes the scalar stored procedure, returning the scalar result, asynchronously.
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="connection">The connection.</param>
        /// <param name="errorContext">The error context.</param>
        /// <returns>
        /// The result of execution of the scalar stored procedure.
        /// </returns>
        Task<object> ExecuteScalarStoredProcedureAsync(string storedProcedureName, IEnumerable<DbParameter> parameters, IDbConnection connection, Func<DatabaseTowelException, Task<object>> errorContext);
    }
}
