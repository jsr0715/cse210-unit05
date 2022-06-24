using Unit05_cycle.Game.Casting;


namespace Unit05_cycle.Game.Scripting 
{
    
    public interface Action
    {
        
        /// <param name="cast">The cast of actors.</param>
        /// <param name="script">The script of actions.</param>
        void Execute(Cast cast, Script script);
    }
}