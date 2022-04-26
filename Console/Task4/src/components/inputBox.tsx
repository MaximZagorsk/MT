import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import { Button } from '@mui/material';
import './form1.css';

const BasicTextFields = () => {
  const [errorTextName, setErrorTextName] = React.useState("");
  const [errorTextDate, setErrorTextDate] = React.useState("");
  const [errorTextBoolName, setErrorTextBoolName] = React.useState(false);
  const [errorTextBoolDate, setErrorTextBoolDate] = React.useState(false);

  const [name, setName] = React.useState("");
  const [date, setDate] = React.useState("");
  const [bageName, setBageName] = React.useState("");
  const [bageDate, setBageDate] = React.useState("");
  const userNameRegExp = "^[a-zA-Zа-яА-Я]([-']?[a-zа-я]+)*( [a-zA-Zа-яА-Я]([-']?[a-zа-я]+)*)+$";
  const dateRegExp = "((0?[1-9]|[12][0-9]|3[01])\\.(0?[1-9]|1[012])\\.(?:19|20)[0-9][0-9])$";

  const handleBadgeForm = () => {

    if (!name.match(userNameRegExp)) {
      setErrorTextName("Введите имя формата: Иван Иванов");
      setErrorTextBoolName(true);
    } else if (!date.match(dateRegExp)) {
      setErrorTextDate("Введите дату формата: дд.мм.гггг");
      setErrorTextBoolDate(true);
    } else if (name.match(userNameRegExp) && date.match(dateRegExp)) {
      handleBage(name, date);

      setErrorTextBoolDate(false);
      setErrorTextBoolName(false);

      setErrorTextName("");
      setErrorTextDate("");
    }
  }

  const handleBage = (name: string, date: string) => {

    setBageName(name);
    setBageDate(date);
  }

  return (
    <
      >
      <form className="form1">
        <TextField id="outlined-basic" label="Имя" variant="outlined" sx={{paddingBottom: "10px"}}
          required={true}
          value={name}
          error={errorTextBoolName}
          helperText={errorTextName}
          onChange={(event: React.ChangeEvent<HTMLInputElement>) => {
            setName(event.target.value);
          }} />
        <TextField id="outlined-basic" label="Дата" variant="outlined" sx={{paddingBottom: "10px"}}
          value={date}
          error={errorTextBoolDate}
          helperText={errorTextDate}
          onChange={(event: React.ChangeEvent<HTMLInputElement>) => {
            setDate(event.target.value);
          }} />
        <Button variant="contained" onClick={handleBadgeForm}>Создать бейдж</Button>
      </form>
      <div>
        <h1>
          Бейджик
        </h1>
        <form>
          <h5>Имя</h5>
          <TextField id="outlined-basic"  
            value={bageName}
          />
          <h5>Дата</h5>
          <TextField id="outlined-basic"
            value={bageDate}
          />
        </form>
      </div>


    </>


  );
}
export { BasicTextFields }