document.addEventListener('DOMContentLoaded',() => {
    const randoButton = document.getElementById('rando');
    randoButton.addEventListener('click',(event) =>{
      const movies = document.getElementById('container');
      while(movies.firstChild)
      {
        movies.firstChild.remove();
      }
      
      fetch("https://localhost:44319/Movie",{
        method: 'GET',
        
        headers:{
          'Accept': 'application/json',
          'Access-Control-Allow-Origin': '*'
        },
        
      })
      .then(response => response.json())
       
         
    
      .then((data) => {
       
        for(let i = 0; i < data.results.length; i++)
        {
          buildMovie(data.results[i]);
        }
        
      })
      .catch((error) => {
        console.log(error);
      })

    })

})
function buildMovie(movie)
{
  const container = document.getElementById('container');
  const poster = document.createElement('div');
  const info = document.createElement('div');
  const image = document.createElement('img');
  const title = document.createElement("h1");
  const year = document.createElement('h2');
  const imdbid = document.createElement('h2');
  const overview = document.createElement('h2');
  const popularity = document.createElement('p');
  const avgVote = document.createElement('h3');
  const save = document.createElement('button');
  save.innerText = "Save Movie";

  image.src = `https://image.tmdb.org/t/p/w185${movie.poster_path}`;
  
  title.innerText = movie.title;
  year.innerText = movie.release_date;
  imdbid.innerText = movie.id;
  overview.innerText = movie.overview;
  popularity.innerText = movie.popularity;
  avgVote.innerText = movie.vote_Average;
  poster.appendChild(image);
  info.appendChild(poster);
  info.appendChild(title);
  info.appendChild(year);
 info.appendChild(imdbid);
  info.appendChild(overview);
  info.appendChild(popularity);
  info.appendChild(avgVote);
  info.appendChild(save);
  container.appendChild(info);



}

