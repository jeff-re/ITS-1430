using System.Collections.Generic;

namespace Itse1430.MovieLib
{
    /// <summary>Provides a database of movies.</summary>
    public interface IMovieDatabase
    {
        /// <summary>Add a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The new movie.</returns>
        /// TODO: Null
        /// TODO: Invalid
        /// TODO: Already exists
        Movie Add ( Movie movie );

        /// <summary>Gets a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <returns>The movie, if any.</returns>
        /// TODO: ID is invalid
        Movie Get ( int id );

        /// <summary>Gets all movies.</summary>
        /// <returns>Returns the movies.</returns>
        IEnumerable<Movie> GetAll ();

        /// <summary>Removes a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// TODO: ID is invalid
        void Remove ( int id );

        /// <summary>Updates a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <param name="newMovie">The movie to add.</param>
        /// TODO: Null
        /// TODO: Invalid
        /// TODO: Already exists
        /// TODO: Does not exist
        void Update ( int id, Movie newMovie );
    }
}