import './lib/bootstrap/dist/css/bootstrap.min.css';
import './App.css';

import { useState } from 'react';

import { useNavigate } from 'react-router-dom';

import { AuthContext } from './contexts/AuthContext';
import { routeAddresses } from './Router';

import * as UserService from './services/UserService';

import { Footer } from './components/footer/Footer';
import { Header } from './components/header/Header';
import { Main } from './components/main/Main';

function App() {
 
 
  const [user, setuser] = useState([]);
  const navigate = useNavigate();
  const onLoginSubmit = async (data) => {
    UserService.Login(data.email, data.password)
        .then(r => {
            if (r.status == 200) {
                alert("Login successfully!");

                r.json()
                    .then(e => {
                        {setuser(e)};
                    });
                navigate(routeAddresses.home);
            } else if (r.status == 400) {
                r.json()
                    .then(e => {
                        if (e.errors != null) {
                            var err = '';
                            for (const element of Object.values(e.errors)) {
                                err += element;
                                err += '. ';
                            }
                            console.log(err);
                            alert(err);
                        } else {
                            alert(e);
                        }

                    });

            } else {
                alert("Application error.")
            }
        })
};

const contextValues = {
  id: user.id,
  accessToken: user.accessToken,
  isAuthenticated: !!user.accessToken
};

  return (
    
    <>
      <AuthContext.Provider value={contextValues}>
        <Header />
        <Main contextValues={contextValues} user={user} setuser={setuser} onLoginSubmit={onLoginSubmit}/>
        <Footer />
      </AuthContext.Provider>
    </>
  );
}

export default App;
